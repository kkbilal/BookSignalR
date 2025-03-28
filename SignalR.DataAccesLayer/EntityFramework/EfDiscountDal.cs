﻿using SignalR.DataAccesLayer.Abstract;
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
	public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
	{
		public EfDiscountDal(SignalRContext context) : base(context)
		{
		}

        public void ChangeStatusToFalse(int id)
        {
            using var context = new SignalRContext();
            var value = context.Discounts.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void ChangeStatusToTrue(int id)
        {
            using var context = new SignalRContext();
            var value = context.Discounts.Find(id);
            value.Status = true;
            context.SaveChanges();
        }

		public List<Discount> GetStatusTrue()
		{
            using var context = new SignalRContext();
            var value = context.Discounts.Where(x => x.Status == true).ToList();
            return value;
		}
	}
}
