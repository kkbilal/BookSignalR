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
	public class MoneyCaseManager : IMoneyCaseService
	{
		private readonly IMoneyCaseDal _Imoneycasedal;

		public MoneyCaseManager(IMoneyCaseDal ımoneycasedal)
		{
			_Imoneycasedal = ımoneycasedal;
		}

		public void TAdd(MoneyCase entity)
		{
			_Imoneycasedal.Add(entity);
		}

		public void TDelete(MoneyCase entity)
		{
			_Imoneycasedal.Delete(entity);
		}

		public MoneyCase TGetByID(int id)
		{
			return _Imoneycasedal.GetByID(id);
		}

		public List<MoneyCase> TGetListAll()
		{
			return _Imoneycasedal.GetListAll();
		}

		public decimal TTotalMoneyCaseAmount()
		{
			return _Imoneycasedal.TotalMoneyCaseAmount();
		}

		public void TUpdate(MoneyCase entity)
		{
			_Imoneycasedal.Update(entity);
			
		}
	}
}
