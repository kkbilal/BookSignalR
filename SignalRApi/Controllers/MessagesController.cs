﻿using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessagesController : ControllerBase
	{
		private readonly IMessageService _messageservice;
		private readonly IMapper _mapper;
		public MessagesController(IMessageService messageservice, IMapper mapper)
		{
			_messageservice = messageservice;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ListMessage()
		{
			var value = _mapper.Map<List<ResultMessageDto>>(_messageservice.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateMessage(CreateMessageDto createMessageDto)
		{
			createMessageDto.Status = false;
			var value = _mapper.Map<Message>(createMessageDto);
			_messageservice.TAdd(value);
			return Ok("mesaj eklendi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteMessage(int id)
		{
			var value = _messageservice.TGetByID(id);
			_messageservice.TDelete(value);
			return Ok("mesaj silindi");
		}
		[HttpPut]
		public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
		{
			var value = _mapper.Map<Message>(updateMessageDto);
			_messageservice.TUpdate(value);
			return Ok("mesaj güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetMessage(int id)
		{
			var value = _messageservice.TGetByID(id);
			return Ok(value);
		}
	}
}
