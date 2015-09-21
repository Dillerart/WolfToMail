using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace MailTO
{
    class MailTo
    {
        
        
        private string logMessage = DateTime.Now.ToString("hh:mm dd-MM-yyyy") +"|  Данные были отправлены.";
        public void mailCreate(string smtpServer, string from, string password,
            string mailto, string caption, string message, int port, string filePath)
        {
             MailMessage mail = new MailMessage();
             mail.From = new MailAddress(from);
             mail.To.Add(new MailAddress(mailto));
             mail.Subject = caption;
             mail.Body = message;            
             sendToMail(mail, smtpServer, port, from, password);
             mail.Dispose();
             fileDelete(filePath);

        }
               
        private void sendToMail(MailMessage mail,string smtpServer, int port, string from, string password)
        {
            SmtpClient client = new SmtpClient(smtpServer);
            client.UseDefaultCredentials = true;
            client.Credentials = new NetworkCredential(from, password);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Timeout = 20000;

            try
            {               
                client.Send(mail);
                new WriteLog(logMessage); 
            }
            catch (Exception ex)
            {
                new WriteLog(ex.ToString());
            }
            
        }

        private void fileDelete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

    }
}
