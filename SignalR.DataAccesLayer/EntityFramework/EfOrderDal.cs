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
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EfOrderDal(SignalRContext context) : base(context)
		{
		}

		public decimal LastOrderPrice()
		{
			using var context = new SignalRContext();
			return context.Orders.OrderByDescending(x => x.OrderId).Take(1).Select(p=>p.TotalPrice).FirstOrDefault();
		}

		public int OrderActiveCount()
		{
			using var context = new SignalRContext();
			return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
		}

		public int OrderCount()
		{
			using var context = new SignalRContext();
			return context.Orders.Count();
		}

		public decimal TodayTotalAmount()
		{
			//using var context = new SignalRContext();
			//return context.Orders.Where(x => x.Description == "Hesap Kapatıldı").Where(p => p.Date == DateTime.Parse(DateTime.Now.ToShortDateString())).Sum(y => y.TotalPrice);
			return 0;
		}
	}
}
