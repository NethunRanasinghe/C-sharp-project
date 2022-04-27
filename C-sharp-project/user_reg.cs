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
    public partial class user_reg : Form
    {
        public user_reg()
        {
            InitializeComponent();
        }

        private void sv_Click(object sender, EventArgs e)
        {
            string n = this.nicno.Text;
            string fnr = this.fname.Text;
            string lnr = this.lname.Text;
            string ad1 = this.adrsl1.Text;
            string ad2 = this.adrsl2.Text;
            int ph = int.Parse(this.phonum.Text);
            string ml = this.eml.Text;
            string pr = this.prvnce.Text;

            sql_function_reg objcr = new sql_function_reg();
            objcr.set_regvr(n, fnr, lnr,ad1,ad2, ph,ml, pr);
            objcr.set_rgsql();
            objcr.function_sql_execute();
            customer_reg_sql customer_Reg_Sql = new customer_reg_sql();
           
        }

        private void rst_Click(object sender, EventArgs e)
        {
            this.nicno.Text = "";
            this.fname.Text = "";
            this.lname.Text = "";
            this.adrsl1.Text = "";
            this.adrsl2.Text = "";
            this.phonum.Text = "";
            this.eml.Text = "";
            this.prvnce.Text = "";

        }

        private void jmp_user_reg_Click(object sender, EventArgs e)
        {
            ProfitNloss profitNloss = new ProfitNloss();
            this.Hide();
            profitNloss.Show();

        }

        private void jmp_to_customer_data_Click(object sender, EventArgs e)
        {
            Customer_data customer_Data = new Customer_data();
            this.Hide();
            customer_Data.Show();
        }
    }
}
