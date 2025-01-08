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
	public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingdal;

		public BookingManager(IBookingDal bookingdal)
		{
			_bookingdal = bookingdal;
		}

		public void TAdd(Booking entity)
		{
			_bookingdal.Add(entity);
		}

		public void TDelete(Booking entity)
		{
			_bookingdal.Delete(entity);
		}

		public Booking TGetByID(int id)
		{
			return _bookingdal.GetByID(id);	
		}

		public List<Booking> TGetListAll()
		{
			return _bookingdal.GetListAll();
		}

		public void TUpdate(Booking entity)
		{
			_bookingdal.Update(entity);
		}
	}
}
