using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper; 
		public CategoryController(ICategoryService categoryService, IMapper mapper)
		{
			_categoryService = categoryService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ListCategory()
		{
			var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateCategory(CreateCategoryDto createCategoryDto) 
		{
	
			_categoryService.TAdd(new Category() { 
				CategoryName = createCategoryDto.CategoryName,
				Status = createCategoryDto.Status,
			});
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			_categoryService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			
			_categoryService.TUpdate(new Category() {
				CategoryId = updateCategoryDto.CategoryId,
				CategoryName = updateCategoryDto.CategoryName,
				Status = updateCategoryDto.Status,
			});
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			return Ok(value);
		}
	}
}
