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
	public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(SignalRContext context) : base(context)
		{
		}

        public void BookingStatusApproved(int id)
        {
            using var context = new SignalRContext();   
            var value = context.Bookings.Find(id);
            value.Description = "Rezervasyon Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusCancelled(int id)
        {
            using var context = new SignalRContext();
            var value = context.Bookings.Find(id);
            value.Description = "Rezervasyon İptal Edildi";
            context.SaveChanges();
        }
    }
}
