using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EduHomeBack.Utils
{
    public static class Helper
    {
        public static async Task SendMessage(string messageSubject, string messageBody, string mailTo)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);
            client.UseDefaultCredentials = false; // bu false olmalidi ki, men oz settinglerimi ede bilim
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("rzshams@hotmail.com", "shema1929");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("rzshams@hotmail.com", mailTo);
            message.Subject = messageSubject;
            message.Body = messageBody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            try
            {
                await client.SendMailAsync(message);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
