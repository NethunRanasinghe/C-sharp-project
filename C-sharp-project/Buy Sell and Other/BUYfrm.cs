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
    public partial class BUYfrm : Form
    {
        string connection_string = Choose_Database.usrdb;

        public BUYfrm()
        {
            InitializeComponent();
            this.buy_usr.Text = login_form.passingText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {

            DTbuy.Text = "";
            CUnm.Text = "";
            buy_cmbtype.Text = null;
            buy_cmbcond.Text = null;
            BUYEScst.Text = "";
            BUYrsn.Text = "";
            BUYTP.Text = "";
        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bck_Click(object sender, EventArgs e)
        {
           
        }

        private void prcd_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connection_string);

            string insertQuery = "INSERT INTO buy(Date,SupplierName,Type,woodCnd,specialNotes,EstimatedPrice,TotalCost)VALUES('"
                + DTbuy.Value.ToString("yyyy-MM-dd")
                + "','"
                + CUnm.Text
                + "','"
                + buy_cmbtype.Text
                + "','"
                + buy_cmbcond.Text
                + "','"
                + BUYrsn.Text
                + "','"
                + BUYEScst.Text
                + "','"
                + BUYTP.Text
                + "')";
            
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Added Successfully","Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DTbuy.Text = "";
                CUnm.Text = "";
                buy_cmbtype.Text = null;
                buy_cmbcond.Text = null;
                BUYEScst.Text = "";
                BUYrsn.Text = "";
                BUYTP.Text = "";
            }
            else
            {
                MessageBox.Show("Unsucessful","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_Selectionmenu = new form_selectionmenu();
            form_Selectionmenu.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void buy_cmbcond_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(buy_cmbcond.SelectedIndex == 2)
            {
                MessageBox.Show("Explain the reason for buying it, if it is damaged or the condition is not so good.","Explain",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
