using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.MessageDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _TestimonialService;
		private readonly IMapper _mapper;
		public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
		{
			_TestimonialService = testimonialService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ListTestimonial()
		{
			var value = _mapper.Map<List<ResultTestimonialDto>>(_TestimonialService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
		{
			var value = _mapper.Map<Testimonial>(createTestimonialDto);
			_TestimonialService.TAdd(value);
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteTestimonial(int id)
		{
			var value = _TestimonialService.TGetByID(id);
			_TestimonialService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
		{
			var value = _mapper.Map<Testimonial>(updateTestimonialDto);

			_TestimonialService.TUpdate(value);
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var value = _TestimonialService.TGetByID(id);
			return Ok(_mapper.Map<GetTestimonialDto>(value));
		}
	}
}
