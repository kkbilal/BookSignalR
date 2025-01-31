using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _ProductService;
		private readonly IMapper _mapper;
		public ProductController(IProductService productService, IMapper mapper)
		{
			_ProductService = productService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ListProduct()
		{
			var value = _mapper.Map<List<ResultProductDto>>(_ProductService.TGetListAll());
			return Ok(value);
		}
		[HttpGet("ProductListWithCategory")]
		public IActionResult ProductListWithCategory()
		{
			var context = new SignalRContext();
			var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
			{
				Description = y.Description,
				Status = y.Status,
				ImageUrl = y.ImageUrl,
				ProductId = y.ProductId,
				Price = y.Price,
				ProductName = y.ProductName,
				CategoryName = y.Category.CategoryName,
			});
			return Ok(values.ToList());
		}
		[HttpPost]
		public IActionResult CreateProduct(CreateProductDto createProductDto)
		{

			_ProductService.TAdd(new Product()
			{
				ProductName = createProductDto.ProductName,
				Description = createProductDto.Description,
				ImageUrl = createProductDto.ImageUrl,
				Price = createProductDto.Price,
				Status = createProductDto.Status,
				CategoryId = createProductDto.CategoryId,
			});
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteProduct(int id)
		{
			var value = _ProductService.TGetByID(id);
			_ProductService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
		{

			_ProductService.TUpdate(new Product()
			{
				ProductId = updateProductDto.ProductId,
				Description = updateProductDto.Description,
				ImageUrl = updateProductDto.ImageUrl,
				Price = updateProductDto.Price,
				ProductName = updateProductDto.ProductName,
				Status = updateProductDto.Status,
				CategoryId = updateProductDto.CategoryId,
			});
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var value = _ProductService.TGetByID(id);
			return Ok(value);
		}
		
	}
}
