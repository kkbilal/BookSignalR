using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class DiscountMapping : Profile
	{
        public DiscountMapping()
        {
            CreateMap<Discount,UpdateDiscountDto>();
			CreateMap<Discount, ResultDiscountDto>();
			CreateMap<Discount, GetDiscountDto>();
			CreateMap<Discount, CreateDiscountDto>();
		}
    }
}
