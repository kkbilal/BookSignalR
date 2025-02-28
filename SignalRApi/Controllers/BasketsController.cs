using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BasketsController : ControllerBase
	{
		private readonly IBasketService _basketService;

		public BasketsController(IBasketService basketService)
		{
			_basketService = basketService;
		}

		[HttpGet]
		public IActionResult GetBasketByTableId(int id)
		{ 
			var values = _basketService.TGetBasketByTableId(id);
			return Ok(values);
		}
		[HttpGet("BasketListByTableMenuWithProductName")]
		public IActionResult BasketListByTableMenuWithProductName(int id)
		{
			using var context =new SignalRContext();
			var values = context.Baskets.Include(x => x.Product).Where(y => y.TableMenuId == id).Select(z => new ResultBasketListWithProducts
			{
				BasketId = z.BasketId,
				Count = z.Count,
				TableMenuId = z.TableMenuId,
				Price = z.Price,
				ProductId = z.ProductId,
				TotalPrice = z.TotalPrice,
				ProductName = z.Product.ProductName,
			}).ToList();
			return Ok(values);
		}
	}
}
