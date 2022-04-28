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
    public partial class cus_form : Form
    {
        public cus_form()
        {
            InitializeComponent();
            this.cus_panel.BackColor = Color.FromArgb(125, Color.Bisque);
        }

        private void cus_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cus_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_selectionmenu objfrmsel = new form_selectionmenu();
            objfrmsel.Show();
        }

        private void cus_btncd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_data objcd = new Customer_data();
            objcd.Show();
        }

        private void cus_btncr_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_reg objur = new user_reg();
            objur.Show();
        }
    }
}
