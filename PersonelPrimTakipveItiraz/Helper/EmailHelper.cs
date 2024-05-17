using System;
using System.Net;
using System.Net.Mail;

public class EmailHelper
{
    private string senderEmail;
    private string senderPassword;

    public EmailHelper()
    {
        this.senderEmail = "proje.vtys@gmail.com";
        this.senderPassword = "VTYS.proje123";
    }

    public bool SendEmail(string recipientEmail, string subject, string body)
    {
        try
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Email gönderilirken bir hata oluştu: " + ex.Message);
            return false;
        }
    }
}