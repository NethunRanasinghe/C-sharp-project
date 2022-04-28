﻿using System;
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
            string select_query = "SELECT first_name FROM `user_details` WHERE first_name NOT IN('Nethun');";

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = select_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    admin_cmbusr.Items.Add(reader.GetString("first_name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful");
            }

        }

        private void usrstate()
        {
            string state_query = "SELECT enabled FROM `user_details` WHERE `first_name` = '"+admin_cmbusr.Text+"';";

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
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful");
            }
        }

        private void sendemail()
        {
            string state_query = "SELECT `email` FROM `user_details` WHERE `first_name` = '"+admin_cmbusr.Text+"';";

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
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful");
            }


            Email_Templates objemail_templates = new Email_Templates();

            string sub = "Urgent Mail From the System Admin (RSMT)";
            string bod = objemail_templates.admin_send_email_template(admin_txtemailc.Text);
            string dlog = "Check your inbox for the code !";

            Email_Auth objemail = new Email_Auth();
            objemail.send_code(gmail, sub, bod, dlog);
            
        }


        private void admin_btnr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Control objadmin = new Admin_Control();
            objadmin.Show();
        }

        private void admin_btndis_Click(object sender, EventArgs e)
        {

            string update_query = "UPDATE `user_details` SET `enabled` = '0' WHERE `first_name` = '"+admin_cmbusr.Text+"';";

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = update_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("User Disabled !", "Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful");
            }

        }

        private void admin_btnen_Click(object sender, EventArgs e)
        {
            string update_query = "UPDATE `user_details` SET `enabled` = '1' WHERE `first_name` = '" + admin_cmbusr.Text + "';";

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = update_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("User Enabled !", "Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful");
            }
        }

        private void admin_btndlt_Click(object sender, EventArgs e)
        {
            string delete_query = "DELETE FROM `user_details` WHERE `user_details`.`first_name` = '"+admin_cmbusr.Text+"'";

            try
            {
                MySqlConnection connection = new MySqlConnection(connection_string);

                string selectQuery = delete_query;
                connection.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("User Deleted !", "Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :- " + ex.Message + "Unsuccessful");
            }
        }


        private void admin_btnsende_Click(object sender, EventArgs e)
        {
            sendemail();
        }

        private void admin_cmbusr_SelectedIndexChanged(object sender, EventArgs e)
        {
            usrstate();
        }

       
    }
}