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
    public partial class Acc_form : Form
    {
        public Acc_form()
        {
            InitializeComponent();
            this.Acc_panel.BackColor = Color.FromArgb(125, Color.Bisque);
        }

        private void Acc_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Acc_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_selectionmenu objfrmselect = new form_selectionmenu();
            objfrmselect.Show();
        }

        private void Acc_btnBuyR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_mbuying objfb = new Form_mbuying();
            objfb.Show();
        }

        private void Acc_btnSellR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_mselling objfs = new Form_mselling();
            objfs.Show();
        }

        private void Acc_btnPL_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfitNloss objpnl = new ProfitNloss();
            objpnl.Show();
        }
    }
}
