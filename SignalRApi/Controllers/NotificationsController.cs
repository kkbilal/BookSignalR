using AutoMapper;
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
        private readonly IMapper _mapper;
		public NotificationsController(INotificationService notificationService, IMapper mapper)
		{
			_notificationService = notificationService;
			_mapper = mapper;
		}

		[HttpGet]
        public IActionResult NotificationList()
        {
            var value = _mapper.Map<List<ResultNotificationDto>>(_notificationService.TGetListAll());
            return Ok(value);
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
            createNotificationDto.Status = false;
            createNotificationDto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			var value = _mapper.Map<Notification>(createNotificationDto);

			
            _notificationService.TAdd(value);
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
			var value = _mapper.Map<Notification>(updateNotificationDto);


			_notificationService.TUpdate(value);

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
