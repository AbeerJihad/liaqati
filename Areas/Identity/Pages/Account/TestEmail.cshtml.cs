using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;
using Org.BouncyCastle.Asn1.Pkcs;
using liaqati_master.Services;
using System.Net.Mail;
using System.Net;
using System.Runtime;

namespace liaqati_master.Areas.Identity.Pages.Account
{
    public class TestEmailModel : PageModel
    {
        public TestEmailModel(MyEmailService emailSender, ILogger<TestEmailModel> logger)
        {
            EmailSender = emailSender;
            Logger = logger;
        }

        public MyEmailService EmailSender { get; }
        public ILogger Logger { get; }

        public async void OnGet()
        {

            try
            {
                await EmailSender.SendEmailAsync("zsilmiyeh@gtc.edu.ps", "Testing email from ASP.Net Core", "This is a testing email from ASP.Net Core App");

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogError(ex.StackTrace);
            }

            try
            {

                //SendEmail();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogError(ex.StackTrace);
            }



            //try
            //{
            //    // Initialize a new instance of the MimeKit.MimeMessage class
            //    var mail = new MimeMessage();

            //    #region Sender / Receiver
            //    // Sender
            //    mail.From.Add(new MailboxAddress("Zakaria Sil", "support@hitham.co"));
            //    mail.Sender = new MailboxAddress("Zakaria Sil", "support@hitham.co");

            //    // Receiver
            //     mail.To.Add(MailboxAddress.Parse("zsilmiyeh@gtc.edu.ps"));

            //    // Set Reply to if specified in mail data
            //    //if (!string.IsNullOrEmpty(mailData.ReplyTo))
            //    //    mail.ReplyTo.Add(new MailboxAddress(mailData.ReplyToName, mailData.ReplyTo));

            //    // BCC
            //    // Check if a BCC was supplied in the request
            //    //if (mailData.Bcc != null)
            //    //{
            //    //    // Get only addresses where value is not null or with whitespace. x = value of address
            //    //    foreach (string mailAddress in mailData.Bcc.Where(x => !string.IsNullOrWhiteSpace(x)))
            //    //        mail.Bcc.Add(MailboxAddress.Parse(mailAddress.Trim()));
            //    //}

            //    // CC
            //    // Check if a CC address was supplied in the request
            //    //if (mailData.Cc != null)
            //    //{
            //    //    foreach (string mailAddress in mailData.Cc.Where(x => !string.IsNullOrWhiteSpace(x)))
            //    //        mail.Cc.Add(MailboxAddress.Parse(mailAddress.Trim()));
            //    //}
            //    #endregion

            //    #region Content

            //    // Add Content to Mime Message
            //    var body = new BodyBuilder();
            //    mail.Subject = "Testing"; // mailData.Subject;
            //    body.HtmlBody = "This is a test"; // mailData.Body;
            //    mail.Body = body.ToMessageBody();

            //    #endregion

            //    #region Send Mail

            //    using var smtp = new SmtpClient();

            //    if (true)
            //    {
            //        await smtp.ConnectAsync("mail.hitham.co", 8889, SecureSocketOptions.StartTls);
            //    }
            //    //else if (_settings.UseStartTls)
            //    //{
            //    //    await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls, ct);
            //    //}

            //    MimeMessage emailMessage = new MimeMessage();
            //    emailMessage.Body = body.ToMessageBody();
            //    await smtp.AuthenticateAsync("support@hitham.co", "support@2023");
            //    await smtp.SendAsync(emailMessage);
            //    await smtp.DisconnectAsync(true);

            //    #endregion

            //    //return true;

            //}
            //catch (Exception)
            //{
            //    //return false;
            //}

        }


        private void SendEmail()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            //create the mail message 
            MailMessage mail = new MailMessage();

            //set the addresses 
            mail.From = new MailAddress("support@hitham.co"); //IMPORTANT: This must be same as your smtp authentication address.
            mail.To.Add("zsilmiyeh@gtc.edu.ps");

            //set the content 
            mail.Subject = "This is an email";
            mail.Body = "This is from system.net.mail using C sharp with smtp authentication.";
            //send the message 
            SmtpClient smtp = new SmtpClient("mail.hitham.co");

            //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
            NetworkCredential Credentials = new NetworkCredential("support@hitham.co", "support@2023");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = Credentials; 
            smtp.Port = 25;    //alternative port number is 8889
            smtp.EnableSsl = false;
            smtp.Send(mail);
            
        }
    }
}
