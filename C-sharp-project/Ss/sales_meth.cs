using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_project
{
    public partial class form_sales : Form
    {
        public form_sales()
        {
            InitializeComponent();
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
            var sawmill = new form_selectionmenu();
            // mekata kalin page eke bname eka dnna mathk krl  selectionmenu.Show();
        }

        private void BTN_sumbit_Click(object sender, EventArgs e)
        {
            //me MySql Connection and MySql Command kyl thynne mnwd kyl ahagnna
          /* MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=sawmillmeth ;SslMode=none"); //methana yata mama customer id eka table ekata dmmata data insert walata wadak nathi nisa dmme nh 
           string insertQuery = "INSERT INTO " +
                "Date,CustomerName,ProductType,WoodType,Estimation,OtherServices,ExtraCharges,)VALUES('" + dateTimePicker.Text + "','" + TXTBX_Cname.Text + "','" + TXTBX_Producttype.Text + "','" + TXTBX_woodtype.Text + "','" + TXTBX_estimation.Text + "','" + TXTBX_otherservices.Text + "','" + TXTBX_extra.Text  + "')";
           connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Added Successfully");
                TXTBX_other.Text = ""; TXTBX_extra.Text = ""; TXTBX_otherservices.Text = ""; TXTBX_estimation.Text = ""; TXTBX_woodtype.Text = ""; TXTBX_Producttype.Text = ""; TXTBX_Cname.Text = "";


            }
            else
            {
                MessageBox.Show("attempt Unsuccessful");
            }
           connection.Close();
          */
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
    }
}
