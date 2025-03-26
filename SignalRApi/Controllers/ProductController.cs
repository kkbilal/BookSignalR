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
		[HttpGet("ProductCount")]
		public IActionResult ProductCount() 
		{
			return Ok(_ProductService.TGetProductCount());
		}
		[HttpGet("ProductPriceByHamburger")]
		public IActionResult ProductPriceByHamburger()
		{
			return Ok(_ProductService.TProductPriceByHamburger());
		}
		[HttpGet("HamburgerProductCount")]
		public IActionResult HamburgerProductCount()
		{
			return Ok(_ProductService.TProductCountByCategoryNameHamburger());
		}
		[HttpGet("GetLast9Products")]
		public IActionResult GetLast9Products() 
		{
			return Ok(_ProductService.TGetLast9Products());
		}
		[HttpGet("DrinkProductCount")]
		public IActionResult DrinkProductCount()
		{
			return Ok(_ProductService.TProductCountByCategoryNameDrink());
		}
		[HttpGet("ProductPriceAvg")]
		public IActionResult ProductPriceAvg()
		{
			return Ok(_ProductService.TProductPriceAvg());
		}
		[HttpGet("ProductPriceMax")]
		public IActionResult ProductPriceMax()
		{
			return Ok(_ProductService.TProductPriceMax());
		}
		[HttpGet("ProductPriceMin")]
		public IActionResult ProductPriceMin()
		{
			return Ok(_ProductService.TProductPriceMin());
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
			var values = _mapper.Map<Product>(createProductDto);
			_ProductService.TAdd(values);
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
			var values = _mapper.Map<Product>(updateProductDto);

			_ProductService.TUpdate(values);
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var value = _ProductService.TGetByID(id);
			return Ok(_mapper.Map<GetProductDto>(value));
		}
		
	}
}
