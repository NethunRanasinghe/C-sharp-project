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
        string connection_string = "server=localhost; user id=root; database=ranasinghesawmilldb";
        public static string passingText;
        public login_form()
        {
            InitializeComponent();
            this.login_panelr.BackColor = Color.FromArgb(125, Color.White);
            this.login_lpanel.BackColor = Color.FromArgb(125, Color.White);


        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void login_txtforgotpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var forgot_pw = new forgot_pw();
            forgot_pw.Show();
        }

        private void login_btnclear_Click(object sender, EventArgs e)
        {
            this.login_txtusr.Text = "";
            this.login_txtpw.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "#1. Check Your User Name and Password again.\n" +
                "#2. Make sure Apache and MySql servers are  running.\n" +
                "#3. Restart the XAMPP Server.\n" +
                "#4. If none of above worked, please contact the main admin.\n" +
                "#5. Contact the developer if step 4 also failed.";

            string title = "Login Help";

            MessageBox.Show(message,title,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sign_up = new sign_up();
            sign_up.Show();
        }

        public void login()
        {
            string query = "SELECT * FROM `user_details` WHERE first_name = '" + login_txtusr.Text + "' AND password = '" + login_txtpw.Text + "'";

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


            }catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void login_btnlogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                passingText = login_txtusr.Text;
                login();
            }
        }

        private void login_txtusr_Enter(object sender, EventArgs e)
        {
            if (login_txtusr.Text == "First Name")
            {
                login_txtusr.Text = null;
            }
            else
            {
                login_txtusr.ForeColor = Color.Black;
            }
        }

        private void login_txtusr_Leave(object sender, EventArgs e)
        {
            if (login_txtusr.Text == "")
            {
                login_txtusr.Text = "First Name";
            }
            else
            {
                login_txtusr.ForeColor = Color.Black;
            }
        }

        private void login_txtpw_Enter(object sender, EventArgs e)
        {
            if (login_txtpw.Text == "Password")
            {
                login_txtpw.Text = null;
                login_txtpw.PasswordChar = '*';
            }
            else
            {
                login_txtpw.ForeColor = Color.Black;
            }
        }

        private void login_txtpw_Leave(object sender, EventArgs e)
        {
            if (login_txtpw.Text == "")
            {
                login_txtpw.Text = "Password";
            }
            else
            {
                login_txtpw.ForeColor = Color.Black;
            }
        }

        private void login_txtusr_Validating(object sender, CancelEventArgs e)
        {
            if (login_txtusr.Text == "First Name")
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
            if (login_txtpw.Text == "Password")
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

        private void login_txtusr_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_reg objmp=new user_reg();
            objmp.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void login_lpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
