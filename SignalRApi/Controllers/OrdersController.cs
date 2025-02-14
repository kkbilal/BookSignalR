using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrdersController(IOrderService orderService)
		{
			_orderService = orderService;
		}
		[HttpGet("OrderCount")]
		public IActionResult OrderCount()
		{
			return Ok(_orderService.TOrderCount());
		}
		[HttpGet("OrderActiveCount")]
		public IActionResult OrderActiveCount()
		{
			return Ok(_orderService.TOrderActiveCount());
		}
		[HttpGet("LastOrderPrice")]
		public IActionResult LastOrderPrice()
		{
			return Ok(_orderService.TLastOrderPrice());
		}
		[HttpGet("TodayTotalAmount")]
		public IActionResult TodayTotalAmount()
		{
			return Ok(_orderService.TTodayTotalAmount());
		}
	}
}
