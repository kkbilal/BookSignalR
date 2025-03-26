﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BookingDtos;
using System.Text;

namespace SignalRWebUI.Controllers
{
    [AllowAnonymous]
    public class BookATableController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public BookATableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingDto createBookingdto)
        {
            
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingdto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7284/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index","Default"); }
            return View();
        }
    }
}
