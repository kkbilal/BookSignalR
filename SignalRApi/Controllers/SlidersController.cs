using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SlidersController : ControllerBase
	{
		private readonly ISliderService _sliderService;
		private readonly IMapper _mapper;
		public SlidersController(ISliderService sliderService, IMapper mapper)
		{
			_sliderService = sliderService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult SliderList()
		{
			var value = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateSlider(CreateSliderDto createSliderDto)
		{
			var values = _mapper.Map<Slider>(createSliderDto);
			_sliderService.TAdd(values);
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteSlider(int id)
		{
			var value = _sliderService.TGetByID(id);
			_sliderService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
		{
			var values = _mapper.Map<Slider>(updateSliderDto);
			_sliderService.TUpdate(values);
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetSlider(int id)
		{
			var value = _sliderService.TGetByID(id);
			return Ok(_mapper.Map<GetSliderDto>(value));
		}
	}
}
