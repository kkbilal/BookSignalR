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
	public class EfBasketDal : GenericRepository<Basket>, IBasketDal
	{
		public EfBasketDal(SignalRContext context) : base(context)
		{
		}

		public List<Basket> GetBasketByTableId(int id)
		{
			using var context = new SignalRContext();
			var values = context.Baskets.Where(x=>x.TableMenuId==id).Include(y=>y.Product).ToList();
			return values;
		}
	}
}
