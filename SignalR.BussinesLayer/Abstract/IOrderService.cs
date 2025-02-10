using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Abstract
{
	public interface IOrderService : IGenericService<Order>
	{
		int TOrderCount();
		int TOrderActiveCount();
		decimal TLastOrderPrice();
	}
}
