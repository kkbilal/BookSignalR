using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SignalRWebUI.Dtos.MailDtos;
using MailKit.Net.Smtp;



namespace SignalRWebUI.Controllers
{
	public class MailController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(CreateMailDto createMailDto)
		{
			MimeMessage mimeMessage = new MimeMessage();
			
			MailboxAddress mailboxAddressFrom = new MailboxAddress("SignalR Rezervasyon", "bilalkaragun04@gmail.com");
			mimeMessage.From.Add(mailboxAddressFrom);

			MailboxAddress mailboxAddressTo = new MailboxAddress("user", createMailDto.RecieverMail);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = createMailDto.Body;
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			mimeMessage.Subject = createMailDto.Subject;

			using var client = new SmtpClient();

			client.Connect("smtp.gmail.com", 587, false);
			client.Authenticate("bilalkaragun04@gmail.com", "rreo uwbo fibq jvsw");

			client.Send(mimeMessage);
			client.Disconnect(true);

			return RedirectToAction("Index","Category");
		}
	}
}
