using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OtomobilFirması.Helper
{
    public static class PasswordReset
    {

        public static void PasswordResetSendEmail(string link, string email)

        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("gercekotomail@gmail.com");
            mail.To.Add($"{email}");
            mail.Subject = $"www.bıdıbı.com::Şifre sıfırlama";
            mail.Body = "<h2>Şifrenizi yenilemek için lütfen aşağıdaki linke tıklayınız.</h2><hr/>";
            mail.Body += $"<a href='{link}'>şifre yenileme linki</a>";
            mail.IsBodyHtml = true;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("gercekotomail@gmail.com", "admin0219");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);


            //MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //mail.From = new MailAddress("gercekotomail@gmail.com");
            //mail.To.Add($"{email}");
            //mail.Subject = $"www.bıdıbı.com::Şifre sıfırlama";
            //mail.Body = "<h2>Şifrenizi yenilemek için lütfen aşağıdaki linke tıklayınız.</h2><hr/>";
            //mail.Body += $"<a href='{link}'>şifre yenileme linki</a>";
            //mail.IsBodyHtml = true;
            //SmtpServer.Port = 587;
            //SmtpServer.Credentials = new System.Net.NetworkCredential("gercekotomail@gmail.com", "admin0219");
            //SmtpServer.EnableSsl = true;
            //SmtpServer.Send(mail);
        }


    }
}
