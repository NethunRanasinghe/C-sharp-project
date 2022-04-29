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

        private void BTN_sumbit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connection_string);

            /*
            string insertQuery = "INSERT INTO salesrecords(" +
              "Date,CustomerName,ProductType,WoodType,Estimation,OtherServices,ExtraCharges,)VALUES('" + dateTimePicker.Text + "','" + TXTBX_Cname.Text + "','" + TXTBX_Producttype.Text + "','" + TXTBX_woodtype.Text + "','" + TXTBX_estimation.Text + "','" + TXTBX_otherservices.Text + "','" + TXTBX_extra.Text + "')";
            */

            string insertQuery = "INSERT INTO `salesrecords` (`Date`, `Customer_name`, `Product_type`, `Product_name`, `Selling_price`, `Other_Services`, `Additional_charges`, `Value`) VALUES('"
                + dateTimePicker.Value.ToString("yyyy-MM-dd")
                + "', '"
                + TXTBX_Cname.Text
                + "', '"
                + TXTBX_Producttype.Text
                + "', '"
                + TXTBX_woodtype.Text
                + "', '"
                + TXTBX_estimation.Text
                + "', '"
                + TXTBX_otherservices.Text
                + "', '"
                + TXTBX_other.Text
                + "', '"
                + TXTBX_extra.Text
                + "');";

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {                  
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Added Successfully","Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTBX_other.Text = ""; 
                    TXTBX_extra.Text = ""; 
                    TXTBX_otherservices.Text = ""; 
                    TXTBX_estimation.Text = ""; 
                    TXTBX_woodtype.Text = ""; 
                    TXTBX_Producttype.Text = ""; 
                    TXTBX_Cname.Text = "";
                }
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Attempt Unsuccessful, Error : - " + ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
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
