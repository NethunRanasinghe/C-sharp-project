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
    public partial class form_sales : Form
    {
        string connection_string = Choose_Database.usrdb;

        public form_sales()
        {
            InitializeComponent();
            sales_usrn.Text = login_form.passingText;
        }

        private void LBL_additionalcharges_Click(object sender, EventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_prevMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_Selectionmenu = new form_selectionmenu();
            form_Selectionmenu.Show();
        }

        private void BTN_sumbit_Click(object sender, EventArgs e)
        {
            /*
            string insertQuery = "INSERT INTO salesrecords(" +
              "Date,CustomerName,ProductType,WoodType,Estimation,OtherServices,ExtraCharges,)VALUES('" + dateTimePicker.Text + "','" + TXTBX_Cname.Text + "','" + TXTBX_Producttype.Text + "','" + TXTBX_woodtype.Text + "','" + TXTBX_estimation.Text + "','" + TXTBX_otherservices.Text + "','" + TXTBX_extra.Text + "')";
            */

            string insertQuery = "INSERT INTO `salesrecords` (`Customer_ID`, `Date`, `Customer_name`, `Product_type`, `Wood_type`, `Estimation`, `Other_Services`, `Additional_charges`, `Extra_charges`) VALUES (NULL, '" + dateTimePicker.Text + "', '" + TXTBX_Cname.Text + "', '" + TXTBX_Producttype + "', '+ TXTBX_woodtype.Text +', '" + TXTBX_estimation.Text + "', '+ TXTBX_otherservices.Text +', 'TXTBX_other.Text', 'TXTBX_extra.Text');";

            MySqlConnection connection = new MySqlConnection(connection_string);                     
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    connection.Open();
                    MessageBox.Show("Added Successfully");
                    TXTBX_other.Text = ""; TXTBX_extra.Text = ""; TXTBX_otherservices.Text = ""; TXTBX_estimation.Text = ""; TXTBX_woodtype.Text = ""; TXTBX_Producttype.Text = ""; TXTBX_Cname.Text = "";
                    connection.Close();


                }
 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Attempt Unsuccessful, Error : - " + ex + "Error");
            }
           
          
        }

        private void TXTBX_otherservices_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TXTBX_other.Text = ""; TXTBX_extra.Text = ""; TXTBX_otherservices.Text = ""; TXTBX_estimation.Text = ""; TXTBX_woodtype.Text = ""; TXTBX_Producttype.Text = ""; TXTBX_Cname.Text = "";
        }

        private void form_sales_Load(object sender, EventArgs e)
        {

        }

        private void LBL_salesrecords_Click(object sender, EventArgs e)
        {

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

        private void sales_usrn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
