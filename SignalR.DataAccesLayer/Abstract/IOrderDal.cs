﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.Abstract
{
	public interface IOrderDal : IGenericDal<Order>
	{
		int OrderCount();
		int OrderActiveCount();
		decimal LastOrderPrice();
		decimal TodayTotalAmount();
	}
}
