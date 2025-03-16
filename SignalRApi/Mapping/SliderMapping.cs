﻿using AutoMapper;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class SliderMapping : Profile
	{
        public SliderMapping()
        {
			CreateMap<Slider, UpdateSliderDto>().ReverseMap();
			CreateMap<Slider, GetSliderDto>().ReverseMap();

			CreateMap<Slider, ResultSliderDto>().ReverseMap();

			CreateMap<Slider, CreateSliderDto>().ReverseMap();
		}
    }
}
