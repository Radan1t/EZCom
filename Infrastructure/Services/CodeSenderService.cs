using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Application.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services
{
    public class CodeSenderService : ICodeSenderService
    {
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string SenderEmail = "pythonmail1984@gmail.com";
        private const string SenderPassword = "dori pxty yult livc";



        public CodeSenderService()
        {
    
        }

        public async Task<(bool success, string message, string code)> SendCodeAsync(string email)
        {
            var random = new Random();
            string code = random.Next(100000, 999999).ToString();

            var smtpClient = new SmtpClient(SmtpServer)
            {
                Port = SmtpPort,
                Credentials = new NetworkCredential(SenderEmail, SenderPassword),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(SenderEmail),
                Subject = "EZCom - Ваш код підтвердження",
                Body = $"Ваш код підтвердження: {code}",
                IsBodyHtml = false
            };

            mailMessage.To.Add(email);

            try
            {
                await smtpClient.SendMailAsync(mailMessage);

                return (true, $"Код підтвердження відправлено на {email}", code);
            }
            catch (Exception ex)
            {

                return (false, $"Помилка при відправці email: {ex.Message}", null);
            }
        }

        public async Task<(bool success, string message)> SendCompanyInviteAsync(string email, string companyName)
        {
            try
            {
                var smtpClient = new SmtpClient(SmtpServer)
                {
                    Port = SmtpPort,
                    Credentials = new NetworkCredential(SenderEmail, SenderPassword),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(SenderEmail),
                    Subject = "Запрошення до компанії в EZCom",
                    Body = $"Вас було додано до компанії {companyName} у системі EZCom.",
                    IsBodyHtml = false
                };

                mailMessage.To.Add(email);

                await smtpClient.SendMailAsync(mailMessage);

                return (true, "Запрошення успішно надіслано.");
            }
            catch (Exception ex)
            {

                return (false, ex.Message);
            }
        }
    }
}
