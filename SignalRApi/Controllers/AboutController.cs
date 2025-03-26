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
			var values = _mapper.Map<About>(createAboutDto);
			_abaoutservice.TAdd(values);
			return Ok("Hakkımda kısmı eklendi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteAbout(int id) 
		{
			var value = _abaoutservice.TGetByID(id);
			_abaoutservice.TDelete(value);
			return Ok("Hakkımda kısmı silindi");
		}
		[HttpPut]
		public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
		{
			var value = _mapper.Map<About>(updateAboutDto);
			_abaoutservice.TUpdate(value);
			return Ok("Hakkımda kısmı güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetAbout(int id)
		{
			var value = _abaoutservice.TGetByID(id);
			return Ok(_mapper.Map<GetAboutDto>(value));
		}
	}
}
