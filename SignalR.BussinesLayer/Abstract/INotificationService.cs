using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        int TNotificationCountByStatusFalse();
        List<Notification> TGetNotificationByStatusFalse();
		void TNotificationChangeStatusToTrue(int id);
		void TNotificationChangeStatusToFalse(int id);
	}
}
