using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public class Emailer
    {
        string settingsPath = ".\\email.txt";
        string senderEmail;
        string name;
        string user;
        string password;

        public Emailer()
        {
            EmailSettings();
        }

        private void EmailSettings()
        {
            foreach (string line in File.ReadLines(settingsPath))
            {
                string[] ln = line.Split(':');

                if (ln[0] == "senderEmail")
                    senderEmail = ln[1];
                if (ln[0] == "name")
                    name = ln[1];
                if (ln[0] == "user")
                    user = ln[1];
                if (ln[0] == "password")
                    password = ln[1];
            }
        }

        public void SendMail(string emailAddress, string subject, string messageBody, bool bodyIsHtml)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(senderEmail, name);
                message.To.Add(new MailAddress(emailAddress));

                message.Subject = subject;

                message.IsBodyHtml = bodyIsHtml;
                message.Body ="<font face=\"consolas\">" + messageBody + "</font>";
                
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(user, password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }


    }
}
