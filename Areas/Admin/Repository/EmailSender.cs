using System.Net;
using System.Net.Mail;

namespace QLBH.Areas.Admin.Repository
{
	public class EmailSender : IEmailSender
	{
		public Task SendEmailAsync(string email, string subject, string message)
		{
			var client = new SmtpClient("smtp.gmail.com", 587)
			{
				EnableSsl = true, 
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential("nhut00090@gmail.com", "sghxydcavfimscnu")
			};

			return client.SendMailAsync(
				new MailMessage(from: "nhut00090@gmail.com",
								to: email,
								subject,
								message
								));
		}
	}
}
