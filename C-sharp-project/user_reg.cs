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
            panel8.Visible=false;
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

        private void jmp_othr_transaction_Click(object sender, EventArgs e)
        {
            ACother2 aCother2 = new ACother2();
            this.Hide();
            aCother2.Show();
        }

        private void jmp_buyform_Click(object sender, EventArgs e)
        {
            BUYfrm bUYfrm = new BUYfrm();
            this.Hide();
            bUYfrm.Show();

        }

        private void jmp_monthly_buy_Click(object sender, EventArgs e)
        {
            Form_mbuying form_Mbuying = new Form_mbuying();
            this.Hide();
            form_Mbuying.Show();
        }

        private void jmp_monthly_sell_Click(object sender, EventArgs e)
        {
            Form_mselling form_Mselling = new Form_mselling();
            this.Hide();
            form_Mselling.Show();
        }

        private void jmp_sales_Click(object sender, EventArgs e)
        {
            form_sales form_Sales = new form_sales();
            this.Hide();
            form_Sales.Show();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            panel8.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            menu.Visible = false;
        }

        private void menu_close_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            menu.Visible = true;
        }
    }
}
