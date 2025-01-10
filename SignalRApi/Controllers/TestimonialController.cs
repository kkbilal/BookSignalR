using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
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

			_TestimonialService.TAdd(new Testimonial()
			{
				Status = createTestimonialDto.Status,
				Comment = createTestimonialDto.Comment,
				ImageUrl = createTestimonialDto.ImageUrl,
				Name = createTestimonialDto.Name,
				Title = createTestimonialDto.Title,
			});
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete]
		public IActionResult DeleteTestimonial(int id)
		{
			var value = _TestimonialService.TGetByID(id);
			_TestimonialService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
		{

			_TestimonialService.TUpdate(new Testimonial()
			{
				TestimonialId = updateTestimonialDto.TestimonialId,
				Status = updateTestimonialDto.Status,
				Comment = updateTestimonialDto.Comment,
				ImageUrl=updateTestimonialDto.ImageUrl,
				Name=updateTestimonialDto.Name,
				Title = updateTestimonialDto.Title,
			});
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("getTestimonial")]
		public IActionResult GetTestimonial(int id)
		{
			var value = _TestimonialService.TGetByID(id);
			return Ok(value);
		}
	}
}
