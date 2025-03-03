﻿using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccesLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Concrete
{
	public class OrderManager : IOrderService
	{
		private readonly IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public void TAdd(Order entity)
		{
			_orderDal.Add(entity);
		}

		public void TDelete(Order entity)
		{
			_orderDal.Delete(entity);
		}

		public Order TGetByID(int id)
		{
			return _orderDal.GetByID(id);
		}

		public List<Order> TGetListAll()
		{
			return _orderDal.GetListAll();
		}

		public decimal TLastOrderPrice()
		{
			return _orderDal.LastOrderPrice();
		}

		public int TOrderActiveCount()
		{
			return _orderDal.OrderActiveCount();
		}

		public int TOrderCount()
		{
			return _orderDal.OrderCount();
		}

		public decimal TTodayTotalAmount()
		{
			return _orderDal.TodayTotalAmount();
		}

		public void TUpdate(Order entity)
		{
			_orderDal.Update(entity);
		}
	}
}
