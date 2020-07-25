using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_stock_quote_alert
{
    public class Email
    {
        public static bool Enviar(string subject, string body)
        {
            try
            {

                SmtpClient client = new SmtpClient(System.Configuration.ConfigurationManager.AppSettings["SMTPHost"],
                                             int.Parse(System.Configuration.ConfigurationManager.AppSettings["SMTPPort"]))
                {
                    Credentials = new NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["CredentialEmail"],
                                                        System.Configuration.ConfigurationManager.AppSettings["CredentialPassword"]),
                    EnableSsl = true
                };

                MailMessage message = new MailMessage();
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                message.Subject = subject;
                message.Body = body;
                message.To.Add(new MailAddress(System.Configuration.ConfigurationManager.AppSettings["EmailTo"]));
                message.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["EmailFrom"]);
                client.Send(message);

                client.Timeout = 0;
                client.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
