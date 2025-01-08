using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class CategoryMapping :Profile
	{
        public CategoryMapping()
        {
            CreateMap<Category,CreateCategoryDto>();
			CreateMap<Category, ResultCategoryDto>();

			CreateMap<Category, GetCategoryDto>();

			CreateMap<Category, UpdateCategoryDto>();
		
		}
    }
}
