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
    public partial class user_reg : Form
    {
        public user_reg()
        {
            InitializeComponent();
        }

        private void sv_Click(object sender, EventArgs e)
        {
           int n = Convert.ToInt32(this.nicno.Text);
            string fnr = this.fname.Text;
            string lnr = this.lname.Text;
            string ad1 = this.adrsl1.Text;
            string ad2 = this.adrsl1.Text;
            int ph = Convert.ToInt32(this.phonum.Text);
            string ml = this.eml.Text;
            string pr = this.prvnce.Text;




            sql_function_reg objcr = new sql_function_reg();
            objcr.set_regvr(n, fnr, lnr,ad1,ad2, ph,ml, pr);
            objcr.set_rgsql();
            objcr.function_sql_execute();
            customer_reg_sql customer_Reg_Sql = new customer_reg_sql();
            MessageBox.Show(customer_Reg_Sql.get_rgsql());

           
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
