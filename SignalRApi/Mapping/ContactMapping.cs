using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class ContactMapping : Profile
	{
        public ContactMapping()
        {
            CreateMap<Contact, UpdateContactDto>();
			CreateMap<Contact, GetContactDto>();

			CreateMap<Contact, UpdateContactDto>();

			CreateMap<Contact, CreateContactDto>();
		}
    }
}
