using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
	public class StatisticController : Controller
	{
		public IActionResult Index()
		{
            string[] colors = { "card-primary", "card-warning", "card-danger", "card-success", "card-info" };
			Random rnd = new Random();
			string randomColor = colors[rnd.Next(colors.Length)];
            ViewBag.CardColor = randomColor;

			string randomColor1 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor1 = randomColor1;

			string randomColor2 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor2 = randomColor2;

			string randomColor3 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor3 = randomColor3;

			string randomColor4 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor4 = randomColor4;

			string randomColor5 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor5 = randomColor5;

			string randomColor6 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor6 = randomColor6;

			string randomColor7 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor7 = randomColor7;

			string randomColor8 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor8 = randomColor8;

			string randomColor9 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor9 = randomColor9;

			string randomColor10 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor10 = randomColor10;

			string randomColor11 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor11 = randomColor11;

			string randomColor12 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor12 = randomColor12;

			string randomColor13 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor13 = randomColor13;

			string randomColor14 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor14 = randomColor14;

			string randomColor15 = colors[rnd.Next(colors.Length)];
			ViewBag.CardColor15 = randomColor15;

			

			return View();
		}
	}
}
