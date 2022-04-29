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
    public partial class ACother2 : Form

    {
        string connection_string = Choose_Database.usrdb;

        public ACother2()
        {
            InitializeComponent();
        }

        private void ACother2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BCK_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OTHERexp = new OTHERexp();
            OTHERexp.Show();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            OTHERdt.Text = "";
            SRVCE.Text = "";
            INFO.Text = "";
            ESTOTHERcst.Text = "";
            CSTother.Text = "";
        }

        private void PRCD_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(connection_string);

            string insertQuery = "INSERT INTO otransaction(`Date`,`Service` ,`AboutService`,`EstimatedCost`,`TotalCost`)VALUES('"
                + OTHERdt.Value.ToString("yyyy-MM-dd")
                + "','"
                + SRVCE.Text
                + "','"
                + INFO.Text
                + "','"
                + ESTOTHERcst.Text
                + "','"
                + CSTother.Text
                + "')";
            
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Added sucessfully");

                OTHERdt.Text = "";
                SRVCE.Text = null;
                INFO.Text = "";
                ESTOTHERcst.Text = "";
                CSTother.Text = "";
            }
            else
            {
                MessageBox.Show("Unsucessful");
            }
            connection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_Selectionmenu = new form_selectionmenu();
            form_Selectionmenu.Show();
        }
    }
}
