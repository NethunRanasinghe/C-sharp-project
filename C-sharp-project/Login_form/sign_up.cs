using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C_sharp_project
{
    public partial class sign_up : Form
    {
        string connection_string = "server=localhost; user id=root; database=rsmt_management_system";

        public int generated_code = 0;
        int signup_val = 1;

        public sign_up()
        {
            InitializeComponent();
            this.signup_pnlsignup.BackColor = Color.FromArgb(125, Color.White);           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "#1. You need to contact the admin before filling the form.\n" +
                "#2. First request the admin auth code and get is from the main admin.\n" +
                "#3. Passwords should meet the mentioned requirements.\n" +
                "#4. Contact the main or secondary admin for more information.\n" +
                "#5. Contact the developer if step 4 also failed.";

            string title = "Sign Up Help";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void signup_btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login_form = new login_form();
            login_form.Show();
        }

        private void signup_txtfn_Enter(object sender, EventArgs e)
        {
            if(signup_txtfn.Text == "First Name")
            {
                signup_txtfn.Text = null;
            }
            else
            {
                signup_txtfn.ForeColor = Color.Black;
            }
        }

        private void signup_txtfn_Leave(object sender, EventArgs e)
        {
            if(signup_txtfn.Text == "")
            {
                signup_txtfn.Text = "First Name";
            }
            else
            {
                signup_txtfn.ForeColor = Color.Black;
            }
        }

        private void signup_txtln_Enter(object sender, EventArgs e)
        {
            if (signup_txtln.Text == "Last Name")
            {
                signup_txtln.Text = null;
            }
            else
            {
                signup_txtln.ForeColor = Color.Black;
            }
        }

        private void signup_txtln_Leave(object sender, EventArgs e)
        {
            if (signup_txtln.Text == "")
            {
                signup_txtln.Text = "Last Name";
            }
            else
            {
                signup_txtln.ForeColor = Color.Black;
            }
        }

        private void signup_txtemail_Enter(object sender, EventArgs e)
        {
            if (signup_txtemail.Text == "Email")
            {
                signup_txtemail.Text = null;
            }
            else
            {
                signup_txtemail.ForeColor = Color.Black;
            }
        }

        private void signup_txtemail_Leave(object sender, EventArgs e)
        {
            if (signup_txtemail.Text == "")
            {
                signup_txtemail.Text = "Email";
            }
            else
            {
                signup_txtemail.ForeColor = Color.Black;
            }
        }

        private void signup_txtposition_Enter(object sender, EventArgs e)
        {
            if (signup_txtposition.Text == "Position")
            {
                signup_txtposition.Text = null;
            }
            else
            {
                signup_txtposition.ForeColor = Color.Black;
            }
        }

        private void signup_txtposition_Leave(object sender, EventArgs e)
        {
            if (signup_txtposition.Text == "")
            {
                signup_txtposition.Text = "Position";
            }
            else
            {
                signup_txtposition.ForeColor = Color.Black;
            }
        }

        private void signup_txtcode_Enter(object sender, EventArgs e)
        {
            if (signup_txtcode.Text == "Admin Code")
            {
                signup_txtcode.Text = null;
            }
            else
            {
                signup_txtcode.ForeColor = Color.Black;
            }
        }

        private void signup_txtcode_Leave(object sender, EventArgs e)
        {
            if (signup_txtcode.Text == "")
            {
                signup_txtcode.Text = "Admin Code";
            }
            else
            {
                signup_txtcode.ForeColor = Color.Black;
            }
        }

        private void signup_txtpw_Enter(object sender, EventArgs e)
        {
            if (signup_txtpw.Text == "Password")
            {
                signup_txtpw.Text = null;
                signup_txtpw.PasswordChar = '*';
            }
            else
            {
                signup_txtpw.ForeColor = Color.Black;
            }
        }

        private void signup_txtpw_Leave(object sender, EventArgs e)
        {
            if (signup_txtpw.Text == "")
            {
                signup_txtpw.Text = "Password";
            }
            else
            {
                signup_txtpw.ForeColor = Color.Black;
            }
        }

        private void signup_txtcpw_Enter(object sender, EventArgs e)
        {
            if (signup_txtcpw.Text == "Confirm Password")
            {
                signup_txtcpw.Text = null;
                signup_txtcpw.PasswordChar = '*';
            }
            else
            {
                signup_txtcpw.ForeColor = Color.Black;
            }
        }

        private void signup_txtcpw_Leave(object sender, EventArgs e)
        {
            if (signup_txtcpw.Text == "")
            {
                signup_txtcpw.Text = "Confirm Password";
            }
            else
            {
                signup_txtcpw.ForeColor = Color.Black;
            }
        }

        private void signup_btnrequest_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            generated_code = rnd.Next(100000, 1000000);
            string gmail = "nethun223@gmail.com";
            Email_Templates objemail_templates = new Email_Templates();

            string sub = "New User Request Code";
            string bod = objemail_templates.new_user_auth_template(generated_code);
            string dlog = "Contact Admin to get the code.";

            Email_Auth objemail = new Email_Auth();
            objemail.send_code(gmail, sub, bod, dlog);

        }

        public void signup_db()
        {
            string query = "INSERT INTO user_details(`first_name`, `last_name`, `email`, `position`, `password`) VALUES ('" + signup_txtfn.Text + "', '" + signup_txtln.Text + "', '" + signup_txtemail.Text + "', '"+ signup_txtposition.Text + "', '" + signup_txtpw.Text + "')";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connection_string);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Sign Up complete !");
                databaseConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void signup_btnsignup_Click(object sender, EventArgs e)
        {

            //Email auth check

            Email_Auth objemail = new Email_Auth();
            Validation objvalid = new Validation();

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    int usrvalue = int.Parse(signup_txtcode.Text);

                    //Password and email Validation

                    if (usrvalue >= 0)
                    {
                        //Check auth code
                        if (objemail.check_code(usrvalue, generated_code) == 1)
                        {
                            if (Validation.Email_validation(signup_txtemail.Text) == false)
                            {
                                MessageBox.Show("Invalid email format !", "Error");
                                signup_val = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Admin Code !", "Error");
                            signup_val = 0;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Auth code empty !", "Error");
                }
            }

            if(signup_val == 1 && objvalid.Password_validation(signup_txtpw.Text, signup_txtcpw.Text) == 1)
            {
                signup_db();

                this.Hide();
                login_form lgnform = new login_form();
                lgnform.Show();
            }
        }


        private void signup_pnlsignup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signup_txtcpw_Validating(object sender, CancelEventArgs e)
        {
            if (signup_txtcpw.Text == "Confirm Password")
            {
                e.Cancel = true;
                signup_txtcpw.Focus();
                signup_errp.SetError(signup_txtcpw, "Confirm Password should not be left blank !");
            }
            else
            {
                e.Cancel = false;
                signup_errp.SetError(signup_txtcpw, "");
            }
        }

        private void signup_txtpw_Validating(object sender, CancelEventArgs e)
        {
            if (signup_txtpw.Text == "Password")
            {
                e.Cancel = true;
                signup_txtpw.Focus();
                signup_errp.SetError(signup_txtpw, "Password should not be left blank !");
            }
            else
            {
                e.Cancel = false;
                signup_errp.SetError(signup_txtpw, "");
            }
        }

        private void signup_txtfn_Validating(object sender, CancelEventArgs e)
        {
            if (signup_txtfn.Text == "First Name")
            {
                e.Cancel = true;
                signup_txtfn.Focus();
                signup_errp.SetError(signup_txtfn, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                signup_errp.SetError(signup_txtfn, "");
            }
        }

        private void signup_txtln_Validating(object sender, CancelEventArgs e)
        {
            if (signup_txtln.Text == "Last Name")
            {
                e.Cancel = true;
                signup_txtln.Focus();
                signup_errp.SetError(signup_txtln, "Last Name should not be left blank !");
            }
            else
            {
                e.Cancel = false;
                signup_errp.SetError(signup_txtln, "");
            }
        }

        private void signup_txtemail_Validating(object sender, CancelEventArgs e)
        {
            if (signup_txtemail.Text == "Email")
            {
                e.Cancel = true;
                signup_txtemail.Focus();
                signup_errp.SetError(signup_txtemail, "Email should not be left blank !");
            }
            else
            {
                e.Cancel = false;
                signup_errp.SetError(signup_txtemail, "");
            }
        }

        private void signup_txtposition_Validating(object sender, CancelEventArgs e)
        {
            if (signup_txtposition.Text == "Position")
            {
                e.Cancel = true;
                signup_txtposition.Focus();
                signup_errp.SetError(signup_txtposition, "Position should not be left blank !");
            }
            else
            {
                e.Cancel = false;
                signup_errp.SetError(signup_txtposition, "");
            }
        }

        private void signup_txtcode_Validating(object sender, CancelEventArgs e)
        {
            if (signup_txtcode.Text == "Admin Code")
            {
                e.Cancel = true;
                signup_txtcode.Focus();
                signup_errp.SetError(signup_txtcode, "Auth code should not be left blank !");
            }
            else
            {
                e.Cancel = false;
                signup_errp.SetError(signup_txtcode, "");
            }
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }
    }
    }
