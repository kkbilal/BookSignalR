﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinesLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;
		private readonly IMapper _mapper;
		public ContactController(IContactService contactService, IMapper mapper)
		{
			_contactService = contactService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ListContact()
		{
			var value = _mapper.Map < List <ResultContactDto>> (_contactService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateContact(CreateContactDto createContactDto)
		{
			
			_contactService.TAdd(new Contact()
			{
				Location = createContactDto.Location,
				Phone = createContactDto.Phone,
				Mail = createContactDto.Mail,
				FooterDescription = createContactDto.FooterDescription,
				OpenDays = createContactDto.OpenDays,
				OpenDaysDescription = createContactDto.OpenDaysDescription,
				OpenHours = createContactDto.OpenHours,
				FooterTitle = createContactDto.FooterTitle,
			});
			return Ok("Ekleme işlemi yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteContact(int id) 
		{
			var value = _contactService.TGetByID(id);
			_contactService.TDelete(value);
			return Ok("Silme işlemi yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateContact(UpdateContactDto updateContactDto)
		{
			
			_contactService.TUpdate(new Contact()
			{
				ContactId = updateContactDto.ContactId,
				Location = updateContactDto.Location,
				Phone = updateContactDto.Phone,
				Mail = updateContactDto.Mail,
				FooterDescription = updateContactDto.FooterDescription,
				OpenHours = updateContactDto.OpenHours,
				OpenDays = updateContactDto.OpenDays,
				OpenDaysDescription = updateContactDto.OpenDaysDescription,	
				FooterTitle= updateContactDto.FooterTitle,
			});
			return Ok("Güncelleme işlemi yapıldı");
		}
		[HttpGet("{id}")]
		public IActionResult GetContact(int id)
		{
			var value = _contactService.TGetByID(id);
			return Ok(value);	
		}
	}
}
