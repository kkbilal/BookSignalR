using Microsoft.EntityFrameworkCore;
using SignalR.DataAccesLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;
using SignalR.DataAccesLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(SignalRContext context) : base(context)
		{
		}

		public int GetProductCount()
		{
			using var context = new SignalRContext();
			return context.Products.Count();
		}

		public List<Product> GetProductsWithCategories()
		{
			using var context = new SignalRContext();
			var values = context.Products.Include(x=>x.Category).ToList();
			return values;
		}

		public int ProductCountByCategoryNameDrink()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x=>x.CategoryId==(context.Categories.Where(p=>p.CategoryName=="İçecek").Select(z=>z.CategoryId).FirstOrDefault())).Count();
		}

		public int ProductCountByCategoryNameHamburger()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryId == (context.Categories.Where(p => p.CategoryName == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Count();
		}

		public decimal ProductPriceAvg()
		{
			using var context = new SignalRContext();
			return context.Products.Average(x=>x.Price);
		}

		public decimal ProductPriceByHamburger()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryId == context.Categories.Where(p => p.CategoryName == "Hamburger").Select(z => z.CategoryId).FirstOrDefault()).Average(y=>y.Price);
		}

		public decimal ProductPriceMax()
		{
			using var context = new SignalRContext();
			return context.Products.Max(x=>x.Price);
		}

		public decimal ProductPriceMin()
		{
			using var context = new SignalRContext();
			return context.Products.Min(x => x.Price);
		}
	}
}
