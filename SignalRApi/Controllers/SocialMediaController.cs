using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SocialMediaController : ControllerBase
	{
		private readonly ISocialMediaService _SocialMediaService;
		private readonly IMapper _mapper;
		public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
		{
			_SocialMediaService = socialMediaService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ListSocialMedia()
		{
			var value = _mapper.Map<List<ResultSocialMediaDto>>(_SocialMediaService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
		{

			_SocialMediaService.TAdd(new SocialMedia()
			{
				Title = createSocialMediaDto.Title,
				Icon = createSocialMediaDto.Icon,
				Url = createSocialMediaDto.Url,
			});
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteSocialMedia(int id)
		{
			var value = _SocialMediaService.TGetByID(id);
			_SocialMediaService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
		{

			_SocialMediaService.TUpdate(new SocialMedia()
			{
				SocialMediaId = updateSocialMediaDto.SocialMediaId,
				Icon = updateSocialMediaDto.Icon,
				Title = updateSocialMediaDto.Title,
				Url = updateSocialMediaDto.Url,
			});
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetSocialMedia(int id)
		{
			var value = _SocialMediaService.TGetByID(id);
			return Ok(value);
		}
	}
}
