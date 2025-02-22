using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Http;

using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SlidersController : ControllerBase
	{
		private readonly ISliderService _sliderService;

		public SlidersController(ISliderService sliderService)
		{
			_sliderService = sliderService;
		}
		[HttpGet]
		public IActionResult SliderList()
		{
			return Ok(_sliderService.TGetListAll());
		}
	}
}
