﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.RapidApiDtos;
using System.Net.Http.Headers;

namespace SignalRWebUI.Controllers
{
    [AllowAnonymous]
    public class FoodRapidApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://tasty.p.rapidapi.com/recipes/list?from=0&size=20&tags=under_30_minutes"),
				Headers =
	{
		{ "x-rapidapi-key", "57daf81cd3mshb5d0263c5086034p1498b0jsnf3ff49bd7edc" },
		{ "x-rapidapi-host", "tasty.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				//Console.WriteLine(body);
				var root = JsonConvert.DeserializeObject<RootTastyApi> (body);
				var values = root.results;
				return View(values.ToList());
			}
			
        }
    }
}
