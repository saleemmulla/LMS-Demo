using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LMSUtilities
{
    public class Email
    {
        private static string smtpAddress = "smtp.gmail.com";
        private static int portNumber = 587;
        private static bool enableSSL = true;
        private static string emailFromAddress = "lmsappemail@gmail.com"; //Sender Email Address  
        private static string password = "LmsApp@123"; //Sender Password  
        public static string emailToAddress = "saleemwld@gmail.com"; //Receiver Email Address  
        public static string subject = "Hello";
        public static string body = "Hello, This is Email sending test using gmail.";
        public static void SendEmail()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
         
    }
}
