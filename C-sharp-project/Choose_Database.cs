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
    public partial class Choose_Database : Form
    {
        public static string usrdb;
        public Choose_Database()
        {
            InitializeComponent();
        }

        private void choose_btnCont_Click(object sender, EventArgs e)
        {
            Setusrdb();

            this.Hide();
            login_form objlogin_form = new login_form();
            objlogin_form.Show();

        }


        private void Setusrdb()
        {
            if (this.cdb_combo.Text == "1. Local Database (XAMPP)")
            {
                usrdb = "server=localhost; user id=root; database=ranasinghesawmilldb";
            }
            else if (this.cdb_combo.Text == "2. Remote Database (DigitalOcean) - Recommended")
            {
                usrdb = "datasource=rsmt-management-system-do-user-11431826-0.b.db.ondigitalocean.com; " +
                                    "port=25060; " +
                                    "username=doadmin; " +
                                    "password=AVNS_xJ37XvPtSUi3vzk; " +
                                    "database=ranasinghesawmilldb;";
            }
            else
            {
                MessageBox.Show("Invalid input !", "Error");
            }
        }

        private void cdb_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cdb_combo.SelectedIndex == 0)
            {
                cdb_pic.BackgroundImage = Properties.Resources.xampp;
            }
            else if(cdb_combo.SelectedIndex == 1)
            {
                cdb_pic.BackgroundImage = Properties.Resources.docean;
            }
            else
            {
                cdb_pic.BackgroundImage = null;
            }
        }

        private void cdb_combo_Click(object sender, EventArgs e)
        {
            cdb_combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
