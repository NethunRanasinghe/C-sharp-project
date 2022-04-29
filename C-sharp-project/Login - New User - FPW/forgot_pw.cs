using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C_sharp_project
{
    public partial class forgot_pw : Form
    {
        public int generated_code = 0;
        int fpw_val = 1;
        string connection_string = Choose_Database.usrdb;



        public forgot_pw()
        {
            InitializeComponent();
            this.fpw_pnlfpw.BackColor = Color.FromArgb(125, Color.White);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form login_Form = new login_form();
            login_Form.Show();
        }

        private void fpw_txtemail_Enter(object sender, EventArgs e)
        {
            if (fpw_txtemail.Text == "Email")
            {
                fpw_txtemail.Text = null;
            }
            else
            {
                fpw_txtemail.ForeColor = Color.Black;
            }
        }

        private void fpw_txtemail_Leave(object sender, EventArgs e)
        {
            if (fpw_txtemail.Text == "")
            {
                fpw_txtemail.Text = "Email";
            }
            else
            {
                fpw_txtemail.ForeColor = Color.Black;
            }
        }

        private void fpw_txtauthcode_Enter(object sender, EventArgs e)
        {
            if (fpw_txtauthcode.Text == "Auth Code")
            {
                fpw_txtauthcode.Text = null;
            }
            else
            {
                fpw_txtauthcode.ForeColor = Color.Black;
            }
        }

        private void fpw_txtauthcode_Leave(object sender, EventArgs e)
        {
            if (fpw_txtauthcode.Text == "")
            {
                fpw_txtauthcode.Text = "Auth Code";
            }
            else
            {
                fpw_txtauthcode.ForeColor = Color.Black;
            }
        }

        private void fpw_txtnpw_Enter(object sender, EventArgs e)
        {
            if (fpw_txtnpw.Text == "New Password")
            {
                fpw_txtnpw.Text = null;
                fpw_txtnpw.PasswordChar = '*';
            }
            else
            {
                fpw_txtnpw.ForeColor = Color.Black;
            }
        }

        private void fpw_txtnpw_Leave(object sender, EventArgs e)
        {
            if (fpw_txtnpw.Text == "")
            {
                fpw_txtnpw.Text = "New Password";
            }
            else
            {
                fpw_txtnpw.ForeColor = Color.Black;
            }
        }

        private void fpw_txtcpw_Enter(object sender, EventArgs e)
        {
            if (fpw_txtcpw.Text == "Confirm  New Password")
            {
                fpw_txtcpw.Text = null;
                fpw_txtcpw.PasswordChar= '*';
            }
            else
            {
                fpw_txtcpw.ForeColor = Color.Black;
            }
        }

        private void fpw_txtcpw_Leave(object sender, EventArgs e)
        {
            if (fpw_txtcpw.Text == "")
            {
                fpw_txtcpw.Text = "Confirm  New Password";
            }
            else
            {
                fpw_txtcpw.ForeColor = Color.Black;
            }
        }

        private void fpw_btnrqcode_Click(object sender, EventArgs e) 
        {
            Email_Templates objemail_templates = new Email_Templates();

            if (email_check() == 1)
            {
                Random rnd = new Random();
                generated_code = rnd.Next(100000, 1000000);
                string gmail = fpw_txtemail.ToString();

                string sub = "Password Reset Code";
                string bod = objemail_templates.password_reset_template(generated_code);

                string dlog = "Check your inbox for the code !";

                Email_Auth objemail = new Email_Auth();
                objemail.send_code(gmail, sub, bod, dlog);
            }
            else
            {
                MessageBox.Show("Invalid Email !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void pwchange_db()
        {
            string query = "UPDATE `user_details` SET `password`= '" + fpw_txtnpw.Text + "' WHERE email = '"+ fpw_txtemail.Text + "'";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connection_string);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;



            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.RecordsAffected == 1)
                {
                    MessageBox.Show("Password Change Complete !\nNo. of Records affected : " +reader.RecordsAffected, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No. of Records Affected : " + reader.RecordsAffected,"Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                databaseConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int email_check()
        {

            string query2 = "SELECT * FROM `user_details` WHERE email = '" + fpw_txtemail.Text + "'";
            int emailcheck = 0;

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connection_string);
            MySqlCommand commandDatabase = new MySqlCommand(query2, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    emailcheck = 1;
                }
                else
                {
                    emailcheck = 0;
                }
                databaseConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return emailcheck;
        }

        public void update()
        {
            Email_Auth objemail = new Email_Auth();
            Validation objvalid = new Validation();

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                    try
                    {
                        int usrvalue = int.Parse(fpw_txtauthcode.Text);
                        //Password and email Validation

                        if (usrvalue >= 0)
                        {
                            //Check auth code
                            if (objemail.check_code(usrvalue, generated_code) == 1)
                            {
                                if (Validation.Email_validation(fpw_txtemail.Text) == false)
                                {
                                    MessageBox.Show("Invalid email format !", "Error");
                                    fpw_val = 0;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Admin Code !", "Error");
                                fpw_val = 0;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Auth code empty", "Error");
                    }
            }

            if (fpw_val == 1 && objvalid.Password_validation(fpw_txtnpw.Text, fpw_txtcpw.Text) == 1)
            {

                pwchange_db();
                this.Hide();
                login_form lgnform = new login_form();
                lgnform.Show();
            }
        }

        private void fpw_btncpw_Click(object sender, EventArgs e)
        {
          update();
        }

        private void fpw_pichelp_Click(object sender, EventArgs e)
        {
            string message = "#1. Wait until you get a popup before proceeding to other steps !.\n" +
                "#2. Check whether the entered email address is correct.\n" +
                "#3. Check your spam folder.\n" +
                "#4. If none of above worked, please contact the main admin.\n" +
                "#5. Contact the developer if step 4 also failed.";

            string title = "Password Reset Help";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void forgot_pw_Load(object sender, EventArgs e)
        {

        }

        private void fpw_txtemail_Validating(object sender, CancelEventArgs e)
        {
            if (fpw_txtemail.Text == "Email")
            {
                e.Cancel = true;
                fpw_txtemail.Focus();
                forgot_pw_errp.SetError(fpw_txtemail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                forgot_pw_errp.SetError(fpw_txtemail, "");
            }
        }

        private void fpw_txtauthcode_Validating(object sender, CancelEventArgs e)
        {
            if (fpw_txtauthcode.Text == "Auth Code")
            {
                e.Cancel = true;
                fpw_txtauthcode.Focus();
                forgot_pw_errp.SetError(fpw_txtauthcode, "Auth Code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                forgot_pw_errp.SetError(fpw_txtauthcode, "");
            }
        }

        private void fpw_txtnpw_Validating(object sender, CancelEventArgs e)
        {
            if (fpw_txtnpw.Text == "New Password")
            {
                e.Cancel = true;
                fpw_txtnpw.Focus();
                forgot_pw_errp.SetError(fpw_txtnpw, "New Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                forgot_pw_errp.SetError(fpw_txtnpw, "");
            }
        }

        private void fpw_txtcpw_Validating(object sender, CancelEventArgs e)
        {
            if (fpw_txtcpw.Text == "Confirm  New Password")
            {
                e.Cancel = true;
                fpw_txtcpw.Focus();
                forgot_pw_errp.SetError(fpw_txtcpw, "Confirm  New Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                forgot_pw_errp.SetError(fpw_txtcpw, "");
            }
        }
    }
}
