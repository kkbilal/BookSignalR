using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.Abstract
{
	public interface IProductDal : IGenericDal<Product>
	{
		List<Product> GetProductsWithCategories();
		 int GetProductCount();
		int ProductCountByCategoryNameHamburger();
		int ProductCountByCategoryNameDrink();
		decimal ProductPriceAvg();
		decimal ProductPriceMax();
		decimal ProductPriceMin();
		decimal ProductPriceByHamburger();
		List<Product> GetLast9Products();
	}
}
