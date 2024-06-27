using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MUCOBADI.Emailhelper
{
    public class EmailSender
    {
        private string SenderEmail { get; set; }
        private string SenderHost { get; set; }
        private string SenderPassword { get; set; }
        private int SenderPort { get; set; }
        private bool EnableSSL { get; set; }
        public EmailSender()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json")
                                               .Build();
            SenderEmail = configuration.GetSection("EmailCredentials")["SenderEmail"];
            SenderHost = configuration.GetSection("EmailCredentials")["SenderHost"];
            SenderPassword = configuration.GetSection("EmailCredentials")["SenderPassword"];
            SenderPort = Convert.ToInt32(configuration.GetSection("EmailCredentials")["SenderPort"]);
            EnableSSL = Convert.ToBoolean(configuration.GetSection("EmailCredentials")["EnableSsl"]);
        }

        public async Task sendMessage(string Email, string subject, string body,Attachment attachment, List<string> emails = null)
        {
            try
            {
                using (var message = new MailMessage(SenderEmail, Email))
                {
                    if (emails != null && emails.Count > 0)
                    {
                        foreach (var item in emails)
                        {
                            message.CC.Add(item);
                        }
                    }
                    if(attachment != null)
                    {
                        message.Attachments.Add(attachment);
                    }
                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = true;
                    using (SmtpClient client = new SmtpClient
                    {
                        EnableSsl = EnableSSL,
                        Host = SenderHost,
                        Port = SenderPort,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new NetworkCredential(SenderEmail, SenderPassword)
                    })
                    {
                        await client.SendMailAsync(message);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
