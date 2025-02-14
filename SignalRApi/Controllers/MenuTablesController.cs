using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuTablesController : ControllerBase
	{
		private readonly ITableMenuService _tableMenuService;

		public MenuTablesController(ITableMenuService tableMenuService)
		{
			_tableMenuService = tableMenuService;
		}
		[HttpGet("MenuTableCount")]
		public ActionResult MenuTableCount()
		{
			return Ok(_tableMenuService.TTableMenuCount());

		}
	}
}
