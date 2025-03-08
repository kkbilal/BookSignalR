using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public IActionResult NotificationList()
        {
            return Ok(_notificationService.TGetListAll());
        }
        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse() 
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }
        [HttpGet("GetNotificationByStatusFalse")]
        public IActionResult GetNotificationByStatusFalse()
        {
            return Ok(_notificationService.TGetNotificationByStatusFalse());
        }
        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            Notification notification = new Notification()
            {
                Description = createNotificationDto.Description,
                Type = createNotificationDto.Type,
                Icon = createNotificationDto.Icon, 
                Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                Status = false
            };
            _notificationService.TAdd(notification);
            return Ok("ekleme başarılı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.TGetByID(id);
            _notificationService.TDelete(value);
            return Ok("silme işlemi başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            return Ok(_notificationService.TGetByID(id));
        }
        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            Notification notification = new Notification()
            {
                Description = updateNotificationDto.Description,
                Type = updateNotificationDto.Type,
                Icon = updateNotificationDto.Icon,
                Date = updateNotificationDto.Date,
                Status = updateNotificationDto.Status,
            }; 
            
            return Ok("güncelleme başarılı");
        }
		[HttpGet("NotificationChangeStatusToTrue/{id}")]
		public IActionResult NotificationChangeStatusToTrue(int id)
		{
			_notificationService.TNotificationChangeStatusToTrue(id);
			return Ok("durum değiştirildi.");

		}
		[HttpGet("NotificationChangeStatusToFalse/{id}")]
		public IActionResult NotificationChangeStatusToFalse(int id)
		{
            _notificationService.TNotificationChangeStatusToFalse(id);
			return Ok("durum değiştirildi.");
		}
	}
}
