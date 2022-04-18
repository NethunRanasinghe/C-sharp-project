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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_usr_Click(object sender, EventArgs e)
        {

        }

        private void login_paddusr_Click(object sender, EventArgs e)
        {
            this.Hide();
            var add_usr = new add_usr();
            add_usr.Show();
        }

        private void login_btnclear_Click(object sender, EventArgs e)
        {
            login_txtusr.Text = "";
            login_txtpw.Text = "";
        }

        private void login_lblfpw_Click(object sender, EventArgs e)
        {
            this.Hide();
            var forgot_pw = new forgot_pw();
            forgot_pw.Show();
        }

        private void login_phelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var help = new help();
            help.Show();
        }

        private void login_split_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void login_picbxl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
