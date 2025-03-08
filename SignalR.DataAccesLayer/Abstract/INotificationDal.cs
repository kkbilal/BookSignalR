using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        int NotificationCountByStatusFalse();
        List<Notification> GetNotificationByStatusFalse();
        void NotificationChangeStatusToTrue(int id);
		void NotificationChangeStatusToFalse(int id);
	}
}
