using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class BookingMapping : Profile
	{
		public BookingMapping()
		{
			CreateMap<Booking,CreateBookingDto>().ReverseMap();
			CreateMap<Booking, GetBookingDto>().ReverseMap();
			CreateMap<Booking, ResultBookingDto>().ReverseMap();
			CreateMap<Booking, UpdateBookingDto>().ReverseMap();

		}
	}
}
