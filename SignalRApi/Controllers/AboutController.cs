using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AboutController : ControllerBase
	{
		private readonly IAboutService _abaoutservice;
		private readonly IMapper _mapper;
		public AboutController(IAboutService abaoutservice, IMapper mapper)
		{
			_abaoutservice = abaoutservice;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ListAbout()
		{
			var value = _mapper.Map<List<ResultAboutDto>>( _abaoutservice.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateAbout(CreateAboutDto createAboutDto) 
		{
			
			_abaoutservice.TAdd(new About()
			{
				Title = createAboutDto.Title,
				Description = createAboutDto.Description,
				ImageUrl = createAboutDto.ImageUrl,
			});
			return Ok("Hakkımda kısmı eklendi");
		}
		[HttpDelete]
		public IActionResult DeleteAbout(int id) 
		{
			var value = _abaoutservice.TGetByID(id);
			_abaoutservice.TDelete(value);
			return Ok("Hakkımda kısmı silindi");
		}
		[HttpPut]
		public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
		{
			
			_abaoutservice.TUpdate(new About() 
			{
				AboutId = updateAboutDto.AboutId,
				Title = updateAboutDto.Title,
				Description = updateAboutDto.Description,
				ImageUrl = updateAboutDto.ImageUrl,
			});
			return Ok("Hakkımda kısmı güncellendi");
		}
		[HttpGet("GetAbout")]
		public IActionResult GetAbout(int id)
		{
			var value = _abaoutservice.TGetByID(id);
			return Ok(value);
		}
	}
}
