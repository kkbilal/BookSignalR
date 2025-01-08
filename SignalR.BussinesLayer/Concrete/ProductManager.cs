using SignalR.BussinesLayer.Abstract;
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
		private readonly IProductService _productdal;

		public ProductManager(IProductService productService)
		{
			_productdal = productService;
		}

		public void TAdd(Product entity)
		{
			_productdal.TAdd(entity);
		}

		public void TDelete(Product entity)
		{
			_productdal.TDelete(entity);
		}

		public Product TGetByID(int id)
		{
			return _productdal.TGetByID(id);
		}

		public List<Product> TGetListAll()
		{
			return _productdal.TGetListAll();
		}

		public void TUpdate(Product entity)
		{
			_productdal.TUpdate(entity);
		}
	}
}
