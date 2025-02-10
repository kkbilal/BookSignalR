using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccesLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productdal;

		public ProductManager(IProductDal productdal)
		{
			_productdal = productdal;
		}

		public void TAdd(Product entity)
		{
			_productdal.Add(entity);
		}

		public void TDelete(Product entity)
		{
			_productdal.Delete(entity);
		}

		public Product TGetByID(int id)
		{
			return _productdal.GetByID(id);
		}

		public List<Product> TGetListAll()
		{
			return _productdal.GetListAll();
		}

		public int TGetProductCount()
		{
			return _productdal.GetProductCount();
		}

		public List<Product> TGetProductsWithCategories()
		{
			return _productdal.GetProductsWithCategories();
		}

		public int TProductCountByCategoryNameDrink()
		{
			return _productdal.ProductCountByCategoryNameDrink();
		}

		public int TProductCountByCategoryNameHamburger()
		{
			return _productdal.ProductCountByCategoryNameHamburger();
		}

		public decimal TProductPriceAvg()
		{
			return _productdal.ProductPriceAvg();
		}

		public decimal TProductPriceByHamburger()
		{
			return _productdal.ProductPriceByHamburger();
		}

		public decimal TProductPriceMax()
		{
			return _productdal.ProductPriceMax();
		}

		public decimal TProductPriceMin()
		{
			return _productdal.ProductPriceMin();
		}

		public void TUpdate(Product entity)
		{
			_productdal.Update(entity);
		}
	}
}
