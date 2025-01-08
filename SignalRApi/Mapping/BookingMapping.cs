using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class BookingMapping : Profile
	{
		public BookingMapping()
		{
			CreateMap<Booking,CreateBookingDto>();
			CreateMap<Booking, GetBookingDto>();
			CreateMap<Booking, ResultBookingDto>();
			CreateMap<Booking, UpdateBookingDto>();

		}
	}
}
