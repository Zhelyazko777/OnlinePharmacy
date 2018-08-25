namespace Pharmacy.Web.Areas.Identity.Services
{
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.Extensions.Configuration;
    using System.Net;
    using System.Net.Mail;
    using System.Threading;
    using System.Threading.Tasks;

    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration configuration;

        public EmailSender(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var mail = new MailMessage();
            var smtpServer = new SmtpClient("smtp.gmail.com", 587);
            smtpServer.EnableSsl = true;
            smtpServer.Credentials = new NetworkCredential(this.configuration["GmailMailSender:Email"], this.configuration["GmailMailSender:Password"]);

            mail.From = new MailAddress("zhelyazko777@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = htmlMessage;
            smtpServer.Send(mail);

            return Task.CompletedTask;
        }
    }
}
