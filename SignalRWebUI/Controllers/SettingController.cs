using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRWebUI.Dtos.IdentityDtos;

namespace SignalRWebUI.Controllers
{
	public class SettingController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public SettingController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var value = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditDto userEditdto = new UserEditDto();
			userEditdto.Surname = value.Surname;
			userEditdto.Email = value.Email;
			userEditdto.Username = value.UserName;
			userEditdto.Name = value.Name;

			ViewBag.name = userEditdto.Name;
			ViewBag.email = userEditdto.Email;
			return View(userEditdto);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditDto userEditDto)
		{
			if (userEditDto.Password == userEditDto.ConfirmPassword)
			{
				var user = await _userManager.FindByNameAsync(User.Identity.Name);

				user.Name = userEditDto.Name;
				user.Surname = userEditDto.Surname;
				user.Email = userEditDto.Email;
				user.UserName = userEditDto.Username;
				user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditDto.Password);
				await _userManager.UpdateAsync(user);
				return RedirectToAction("Index", "Category");
			}
			ViewBag.name = userEditDto.Name;
			ViewBag.email = userEditDto.Email;
			return View();
		}
	}
}
