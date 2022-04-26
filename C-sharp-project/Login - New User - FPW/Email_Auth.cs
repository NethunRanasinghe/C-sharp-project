using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_project
{
    internal class Email_Auth
    {
        private int num = 0;
        private string ?wdialog;
        public void send_code(string email, string subject, string body, string dialog)
        {
            wdialog = dialog;

            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "rsmtmanagement@gmail.com",
                    Password = "whvbjdkjkyskgsaq"
                }
            };

            MailAddress FromEmail = new MailAddress("rsmtmanagement@gmail.com", "RSMT Management System");

            try
            {
                MailAddress ToEmail = new MailAddress(email, "Someone");
                MailMessage Message = new MailMessage()
                {
                    From = FromEmail,
                    IsBodyHtml = Regex.IsMatch(body, @"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>"),
                    Subject = subject,
                    Body = body,
                };
                Message.To.Add(ToEmail);

                Client.SendCompleted += Client_SendCompleted;
                Client.SendMailAsync(Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message,"Error");
            }
            
        }

        private void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error : " + e.Error.Message);
                return;
            }
            else
            {
                MessageBox.Show(wdialog, "Successful");
            }
        }

        public int check_code(int usrcode,int genc)
        {
            try
            {
                num = usrcode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

            if (num == genc && num > 100000)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        private void InitializeComponent()
        {
            InitializeComponent();
        }

        private void Email_Auth_Load(object sender, EventArgs e)
        {

        }
    }
}
