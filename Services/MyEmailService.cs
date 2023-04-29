using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using MimeKit.IO;
using System.Security.Authentication;

namespace liaqati_master.Services
{
    public class MyEmailService : IEmailSender
    {
        EmailSettings? _emailSettings = null;
        private readonly IHostEnvironment environment;

        public MyEmailService(EmailSettings emailSetting, IHostEnvironment environment)
        {
            this._emailSettings = emailSetting;
            this.environment = environment;
        }
        public async System.Threading.Tasks.Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            try
            {
                var backupDir = Path.Combine(environment.ContentRootPath, "TempEmails");

                string floag = $"smtp{DateTime.Now.ToString("hhmmss")}.log";

                //var client = new MailKit.Net.Smtp.SmtpClient(new MailKit.ProtocolLogger(floag));

                MimeMessage emailMessage = new();

                MailboxAddress emailFrom = new(_emailSettings.Name, _emailSettings.EmailId);
                emailMessage.From.Add(emailFrom);

                MailboxAddress emailTo = new("Customer", email);
                emailMessage.To.Add(emailTo);

                emailMessage.Subject = subject;

                BodyBuilder emailBodyBuilder = new BodyBuilder();
                emailBodyBuilder.HtmlBody = htmlMessage;
                emailMessage.Body = emailBodyBuilder.ToMessageBody();


                await SaveToPickupDirectory(emailMessage, backupDir);

                SmtpClient emailClient = new(new MailKit.ProtocolLogger(floag));

                if (_emailSettings.UseSSL)
                {
                    emailClient.SslProtocols = SslProtocols.Ssl3 | SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;

                    emailClient.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    await emailClient.ConnectAsync(_emailSettings.Host, _emailSettings.Port, SecureSocketOptions.Auto);
                }
                else
                {
                    await emailClient.ConnectAsync(_emailSettings.Host, _emailSettings.Port, SecureSocketOptions.None);
                }

                emailClient.Authenticate(_emailSettings.EmailId, _emailSettings.Password);
                await emailClient.SendAsync(emailMessage);
                emailClient.Disconnect(true);
                emailClient.Dispose();

            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }


        public static async Task SaveToPickupDirectory(MimeMessage message, string pickupDirectory)
        {
            do
            {
                var path = Path.Combine(pickupDirectory, Guid.NewGuid().ToString() + ".eml");
                Stream stream;

                try
                {
                    stream = File.Open(path, FileMode.CreateNew);
                }
                catch (IOException)
                {
                    if (File.Exists(path))
                        continue;
                    throw;
                }

                try
                {
                    using (stream)
                    {
                        using var filtered = new FilteredStream(stream);
                        filtered.Add(new SmtpDataFilter());

                        var options = FormatOptions.Default.Clone();
                        options.NewLineFormat = NewLineFormat.Dos;

                        await message.WriteToAsync(options, filtered);
                        await filtered.FlushAsync();
                        return;
                    }
                }
                catch
                {
                    File.Delete(path);
                    throw;
                }
            } while (true);
        }
    }
}
