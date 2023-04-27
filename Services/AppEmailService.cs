

using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;

namespace SportProductsWeb.Services
{
    public class AppEmailService : IEmailSender
    {
        private readonly EmailSetting EmailSetting;
        public AppEmailService(EmailSetting emailSetting)
        {
            EmailSetting = emailSetting;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {


                MimeMessage msg = new();
                //   msg.From.Add(new MailboxAddress(encoding: Encoding.UTF8, EmailSetting.Sender, EmailSetting.Email));
                msg.From.Add(new MailboxAddress(EmailSetting.Sender, EmailSetting.Email));
                msg.To.Add(new MailboxAddress("", email));
                msg.Subject = subject;


                BodyBuilder msgBuilder = new()
                {
                    HtmlBody = htmlMessage,

                };

                msg.Body = msgBuilder.ToMessageBody();

                SmtpClient client = new();
                if (EmailSetting.UseSSL)
                {
                    client.SslProtocols =
                        System.Security.Authentication.SslProtocols.Ssl3 |
                        System.Security.Authentication.SslProtocols.Tls12 |
                        System.Security.Authentication.SslProtocols.Tls11;
                    await client.ConnectAsync(host: EmailSetting.Host, EmailSetting.Port, SecureSocketOptions.Auto).ConfigureAwait(false);
                }
                else
                {

                    await client.ConnectAsync(host: EmailSetting.Host, EmailSetting.Port, SecureSocketOptions.None).ConfigureAwait(false);

                }
                await client.AuthenticateAsync(EmailSetting.Email, EmailSetting.Password).ConfigureAwait(false);
                await client.SendAsync(msg).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
                client.Dispose();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
