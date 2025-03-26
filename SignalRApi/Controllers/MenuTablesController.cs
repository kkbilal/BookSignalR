using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuTablesController : ControllerBase
	{
		private readonly ITableMenuService _tableMenuService;
        private readonly IMapper _mapper;
        public MenuTablesController(ITableMenuService tableMenuService, IMapper mapper)
        {
            _tableMenuService = tableMenuService;
            _mapper = mapper;
        }
        [HttpGet("MenuTableCount")]
		public ActionResult MenuTableCount()
		{
			return Ok(_tableMenuService.TTableMenuCount());

		}
        [HttpGet]
        public IActionResult ListMenuTable()
        {
            var value = _mapper.Map<List<ResultMenuTableDto>>(_tableMenuService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            createMenuTableDto.Status = false;
            var value = _mapper.Map<TableMenu>(createMenuTableDto);
            _tableMenuService.TAdd(value);
            return Ok("masa eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMenuTable(int id)
        {
            var value = _tableMenuService.TGetByID(id);
            _tableMenuService.TDelete(value);
            return Ok("masa silindi");
        }
        [HttpPut]
        public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
        {
            var value = _mapper.Map<TableMenu>(updateMenuTableDto);
            _tableMenuService.TUpdate(value);
            return Ok("masa güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetupdatecreateMenuTableDtoDto(int id)
        {
            var value = _tableMenuService.TGetByID(id);
            return Ok(value);
        }
    }
}
