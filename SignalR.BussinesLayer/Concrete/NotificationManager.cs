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
	public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification entity)
        {
            _notificationDal.Add(entity);
        }

        public void TDelete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public Notification TGetByID(int id)
        {
            return _notificationDal.GetByID(id);
        }

        public List<Notification> TGetListAll()
        {
            return _notificationDal.GetListAll();
        }

        public List<Notification> TGetNotificationByStatusFalse()
        {
            return _notificationDal.GetNotificationByStatusFalse();
        }

		public void TNotificationChangeStatusToFalse(int id)
		{
            _notificationDal.NotificationChangeStatusToFalse(id);
		}

		public void TNotificationChangeStatusToTrue(int id)
		{
			_notificationDal.NotificationChangeStatusToTrue(id);
		}

		public int TNotificationCountByStatusFalse()
        {
            return _notificationDal.NotificationCountByStatusFalse();
        }

        public void TUpdate(Notification entity)
        {
           _notificationDal.Update(entity);
        }
    }
}
