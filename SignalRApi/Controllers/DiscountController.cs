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
	public class DiscountController : ControllerBase
	{
		private readonly IDiscountService _discountService;
		private readonly IMapper _mapper;
		public DiscountController(IDiscountService discountService, IMapper mapper)
		{
			_discountService = discountService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ListDiscount() 
		{
			var value =_mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
		{

			_discountService.TAdd(new Discount()
			{
				Title = createDiscountDto.Title,
				Description = createDiscountDto.Description,
				Amount = createDiscountDto.Amount,
				ImageUrl = createDiscountDto.ImageUrl,
			});
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete]
		public IActionResult DeleteDiscount(int id)
		{
			var value = _discountService.TGetByID(id);
			_discountService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
		{

			_discountService.TUpdate(new Discount()
			{
				DiscountId = updateDiscountDto.DiscountId,
				Title = updateDiscountDto.Title,
				Description= updateDiscountDto.Description,
				Amount = updateDiscountDto.Amount,
				ImageUrl = updateDiscountDto.ImageUrl,
			});
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("getDiscount")]
		public IActionResult GetDiscount(int id)
		{
			var value = _discountService.TGetByID(id);
			return Ok(value);
		}


	}
}
