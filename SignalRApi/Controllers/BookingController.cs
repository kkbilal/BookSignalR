using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;

using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingService _bookingService;
		private readonly IMapper _mapper;
		public BookingController(IBookingService bookingService, IMapper mapper)
		{
			_bookingService = bookingService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ListBooking()
		{
			var value = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateBooking(CreateBookingDto createBookingDto)
		{
			
			_bookingService.TAdd(new Booking()
			{
				Mail = createBookingDto.Mail,
				Date = createBookingDto.Date,
				Name = createBookingDto.Name,
				PersonCount = createBookingDto.PersonCount,
				Phone = createBookingDto.Phone,
				Description = createBookingDto.Description,
			});
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBooking(int id)
		{
			var values = _bookingService.TGetByID(id);
			_bookingService.TDelete(values);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
		{
			
			_bookingService.TUpdate(new Booking() { 
				BookingId = updateBookingDto.BookingId,
				Mail = updateBookingDto.Mail,
				Date = updateBookingDto.Date,
				Name = updateBookingDto.Name,
				PersonCount = updateBookingDto.PersonCount,
				Phone = updateBookingDto.Phone,
			
			});
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetBooking(int id)
		{
			var value = _bookingService.TGetByID(id);
			return Ok(value);
		}
        [HttpGet("BookingStatusApproved/{id}")]
        public IActionResult BookingStatusApproved(int id)
        {
			_bookingService.TBookingStatusApproved(id);
            return Ok("onay başarılı");

        }
        [HttpGet("BookingStatusCancelled/{id}")]
        public IActionResult BookingStatusCancelled(int id)
        {
            _bookingService.TBookingStatusCancelled(id);
            return Ok("iptal başarılı");

        }
    }
}
