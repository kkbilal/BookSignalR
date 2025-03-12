using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MenuTableMapping : Profile
    {
        public MenuTableMapping()
        {
            CreateMap<TableMenu, CreateMenuTableDto>().ReverseMap();
            CreateMap<TableMenu, ResultMenuTableDto>().ReverseMap();

            

            CreateMap<TableMenu, UpdateMenuTableDto>().ReverseMap();

        }
    }
}
