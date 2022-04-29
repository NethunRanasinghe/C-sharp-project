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
    public partial class Admin_Control : Form
    {
        string connection_string = Choose_Database.usrdb;
        string user="";

        //For testing
        //string connection_string = "server=localhost; user id=root; database=systdb";

        public string gmail="";

        public Admin_Control()
        {
            InitializeComponent();
            fill_combo();
            this.admin_lblpanel.BackColor = Color.FromArgb(125, Color.Bisque);       
            
        }

        private void admin_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_selectionmenu objselect = new form_selectionmenu();
            objselect.Show();
        }



        private void fill_combo()
        {
            string select_query = "SELECT CONCAT(`first_name`,' ',`last_name`) AS full_name FROM `user_details` WHERE `email` NOT IN('nethun223@gmail.com');";

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = select_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    admin_cmbusr.Items.Add(reader.GetString("full_name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void usrstate()
        {
            string state_query = "SELECT enabled FROM `user_details` WHERE `first_name` = '"+ user + "';";

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = state_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == 1)
                    {
                        admin_enb.Text = "Enabled";
                    }
                    else
                    {
                        admin_enb.Text = "Disabled";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendemail()
        {
            string state_query = "SELECT `email` FROM `user_details` WHERE `first_name` = '"+ user + "';";

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = state_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   gmail = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Email_Templates objemail_templates = new Email_Templates();

            string sub = "Urgent Mail From the System Admin (RSMT)";
            string bod = objemail_templates.admin_send_email_template(admin_txtemailc.Text);
            string dlog = "Email Successfully Sent !";

            Email_Auth objemail = new Email_Auth();
            objemail.send_code(gmail, sub, bod, dlog);
            
        }

        private void log()
        {
            string log_query = "SELECT `Time` FROM `user_details_time` WHERE `first_name` = '"+user+"' && `email` NOT IN('nethun223@gmail.com');";
            MySqlDataAdapter adapter = new MySqlDataAdapter(log_query,connection_string);
            DataTable table = new DataTable();
            adapter.Fill(table);

            admin_datalog.DataSource = table;
        }


        private void admin_btnr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Control objadmin = new Admin_Control();
            objadmin.Show();
        }

        private void admin_btndis_Click(object sender, EventArgs e)
        {

            string update_query = "UPDATE `user_details` SET `enabled` = '0' WHERE `first_name` = '"+ user + "';";
            
            Cursor tempCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = update_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("User Disabled !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = tempCursor;

        }

        private void admin_btnen_Click(object sender, EventArgs e)
        {
            string update_query = "UPDATE `user_details` SET `enabled` = '1' WHERE `first_name` = '" + user + "';";

            Cursor tempCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = update_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("User Enabled !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = tempCursor;
        }

        private void admin_btndlt_Click(object sender, EventArgs e)
        {
            string delete_query = "DELETE FROM `user_details` WHERE `user_details`.`first_name` = '"+ user + "'";

            Cursor tempCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = delete_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("User Deleted !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = tempCursor;
        }


        private void admin_btnsende_Click(object sender, EventArgs e)
        {
            Cursor tempCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            sendemail();

            Cursor.Current = tempCursor;
        }

        private void admin_cmbusr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor tempCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            string[] usrsplit = admin_cmbusr.Text.Split();
            user = usrsplit[0];

            //string[] usrsplit = admin_cmbusr.Text.Split('\u002C');

            usrstate();
            log();

            Cursor.Current = tempCursor;
        }

       
    }
}
