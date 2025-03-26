﻿using AutoMapper;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class MessageMapping : Profile
	{
		public MessageMapping()
		{
			CreateMap<Message, CreateMessageDto>().ReverseMap();
			CreateMap<Message, ResultMessageDto>().ReverseMap();
			CreateMap<Message, UpdateMessageDto>().ReverseMap();
		}
	}
}
