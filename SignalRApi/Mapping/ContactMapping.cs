using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class ContactMapping : Profile
	{
        public ContactMapping()
        {
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
			CreateMap<Contact, GetContactDto>().ReverseMap();

			CreateMap<Contact, UpdateContactDto>().ReverseMap();

			CreateMap<Contact, CreateContactDto>().ReverseMap();
		}
    }
}
