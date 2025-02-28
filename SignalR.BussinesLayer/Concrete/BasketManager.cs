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
	public class BasketManager : IBasketService
	{
		private readonly IBasketDal _basketdal;

		public BasketManager(IBasketDal basketdal)
		{
			_basketdal = basketdal;
		}

		public void TAdd(Basket entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Basket entity)
		{
			throw new NotImplementedException();
		}

		public List<Basket> TGetBasketByTableId(int id)
		{
			return _basketdal.GetBasketByTableId(id);
		}

		public Basket TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Basket> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Basket entity)
		{
			throw new NotImplementedException();
		}
	}
}
