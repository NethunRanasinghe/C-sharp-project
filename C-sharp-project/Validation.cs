using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_project
{
    internal class Validation
    {
        public int Password_validation(string pass,string cpass)
        {
            int validator = 1;

            //Check length
            if (pass.Length < 8)
            {
                MessageBox.Show("Password doesn't meet minimum required length !", "Error");
                validator = 0;
            }

            //Check for uppercase characters
            if (pass.Any(char.IsUpper) == false)
            {
                MessageBox.Show("Password should contain uppercase characters !", "Error");
                validator = 0;
            }

            //Check for numbers
            if (pass.Any(char.IsDigit) == false)
            {
                MessageBox.Show("Password should contain numbers !", "Error");
                validator = 0;
            }

            //Check for special characters
            string str = pass;
            char[] one = str.ToCharArray();
            int c = 0;
            for (int i = 0; i < one.Length; i++)
            {
                if (!Char.IsLetterOrDigit(one[i]))
                {
                    c++;
                }
            }

            if (c == 0)
            {
                MessageBox.Show("Password should contain symbols !", "Error");
                validator = 0;
            }

            //Check whether the password and confirm password match.
            if (pass != cpass)
            {
                MessageBox.Show("Passwords Does not match !", "Error");
                validator = 0;
            }

            return validator;
        }

        public static bool Email_validation(string email)
        {
            
             var trimmedEmail = email.Trim();

             if (trimmedEmail.EndsWith("."))
             {
                return false;
             }
             try
             {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
             }
             catch
             {
                return false;
             }
        }
    }
}
