﻿using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class CategoryMapping :Profile
	{
        public CategoryMapping()
        {
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
			CreateMap<Category, ResultCategoryDto>().ReverseMap();

			CreateMap<Category, GetCategoryDto>().ReverseMap();

			CreateMap<Category, UpdateCategoryDto>().ReverseMap();
		
		}
    }
}
