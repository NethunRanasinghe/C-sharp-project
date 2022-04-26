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
    public partial class login_form : Form
    {
        string connection_string = "datasource=rsmt-management-system-do-user-11431826-0.b.db.ondigitalocean.com; " +
                                    "port=25060; " +
                                    "username=doadmin; " +
                                    "password=AVNS_xJ37XvPtSUi3vzk; " +
                                    "database=ranasinghesawmilldb;";
        
        public static string ?passingText;

        public login_form()
        {
            InitializeComponent();
            this.login_bpanel.BackColor = Color.FromArgb(125, Color.Bisque);
        }

        private void login_lblfpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forgot_pw objforgotpw = new forgot_pw();
            objforgotpw.Show();
        }

        private void login_btnclear_Click(object sender, EventArgs e)
        {
            this.login_txtusr.Texts = "";
            this.login_txtpw.Texts  = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_up objsignup = new sign_up();
            objsignup.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "#1. Check Your User Name and Password again.\n" +
                "#2. Make sure Apache and MySql servers are  running.\n" +
                "#3. Restart the XAMPP Server.\n" +
                "#4. If none of above worked, please contact the main admin.\n" +
                "#5. Contact the developer if step 4 also failed.";

            string title = "Login Help";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void login_btnlgin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                passingText = login_txtusr.Texts;
                Action_login();
            }
        }

        //..Custom Methods..//
        public void Action_login()
        {
            string query = "SELECT * FROM `user_details` WHERE first_name = '" + login_txtusr.Texts + "' AND password = '" +login_txtpw.Texts + "'";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connection_string);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    this.Hide();
                    form_selectionmenu objsel = new form_selectionmenu();
                    objsel.Show();
                }
                else
                {
                    MessageBox.Show("User name and Password does not match !");
                }
                databaseConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        //..Event Handlers..//

        private void login_txtusr_Enter(object sender, EventArgs e)
        {
            if (login_txtusr.Texts == "First Name")
            {
                login_txtusr.Texts = null;
            }
            else
            {
                login_txtusr.ForeColor = Color.Black;
            }
        }

        private void login_txtusr_Leave(object sender, EventArgs e)
        {
            if (login_txtusr.Texts == "")
            {
                login_txtusr.Texts = "First Name";
            }
            else
            {
                login_txtusr.ForeColor = Color.Black;
            }
        }

        private void login_txtpw_Enter(object sender, EventArgs e)
        {
            if (login_txtpw.Texts == "Password")
            {
                login_txtpw.Texts = null;
                login_txtpw.PasswordChar = true;
            }
            else
            {
                login_txtpw.ForeColor = Color.Black;
            }
        }

        private void login_txtpw_Leave(object sender, EventArgs e)
        {
            if (login_txtpw.Texts == "")
            {
                login_txtpw.Texts = "Password";
            }
            else
            {
                login_txtpw.ForeColor = Color.Black;
            }
        }

        private void login_txtusr_Validating(object sender, CancelEventArgs e)
        {
            if (login_txtusr.Texts == "First Name")
            {
                e.Cancel = true;
                login_txtusr.Focus();
                login_errp.SetError(login_txtusr, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                login_errp.SetError(login_txtusr, "");
            }
        }

        private void login_txtpw_Validating(object sender, CancelEventArgs e)
        {
            if (login_txtpw.Texts == "Password")
            {
                e.Cancel = true;
                login_txtpw.Focus();
                login_errp.SetError(login_txtpw, "Password should not be left blank !");
            }
            else
            {
                e.Cancel = false;
                login_errp.SetError(login_txtpw, "");
            }
        }
    }
}
