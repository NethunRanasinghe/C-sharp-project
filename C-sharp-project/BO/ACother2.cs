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

        private void INFO_TextChanged(object sender, EventArgs e)
        {

        }

        private void EXTbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Enter as (1) for purchase of new machinery, (2) for sale of old machinery and (3) for repair of machinery.");
        }

        private void PRCD_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=process;SslMode=none");
            string insertQuery = "INSERT INTO otransaction(Date,Service ,AboutService,EstimatedCost,TotalCost)VALUES('" + OTHERdt.Text + "','" + SRVCE.Text + "','" + INFO.Text + "','" + ESTOTHERcst.Text + "','" + CSTother.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Added sucessfully");

                OTHERdt.Text = "";
                SRVCE.Text = "";
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
    }
}
