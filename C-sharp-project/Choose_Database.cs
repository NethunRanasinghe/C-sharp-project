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

        public static string usrdb = "";
        public static string login_info = "";
        public static string DBType="";

        public Choose_Database()
        {
            InitializeComponent();
        }

        private void choose_btnCont_Click(object sender, EventArgs e)
        {
            Setusrdb();

            if (usrdb != "error")
            {
                this.Hide();
                login_form objlogin_form = new login_form();
                objlogin_form.Show();
            }

        }


        private void Setusrdb()
        {
            if (this.cdb_combo.Text == "1. Local Database (XAMPP)")
            {
                DBType = "xampp";
                usrdb = "server=localhost; user id=root; database=systdb";

                login_info = "#1. Check Your User Name and Password again.\n" +
                "#2. Make sure Apache and MySql servers are  running.\n" +
                "#3. Restart the XAMPP Server.\n" +
                "#4. If none of above worked, please contact the main admin.\n" +
                "#5. Contact the developer if step 4 also failed.";
            }
            else if (this.cdb_combo.Text == "2. Remote Database (DigitalOcean) - Recommended")
            {
                DBType = "dcean";
                usrdb = "datasource=rsmt-management-system-do-user-11431826-0.b.db.ondigitalocean.com; " +
                                    "port=25060; " +
                                    "username=doadmin; " +
                                    "password=AVNS_xJ37XvPtSUi3vzk; " +
                                    "database=systdb;";

                login_info = "#1. Check Your User Name and Password again.\n" +
                "#2. Check your internet connection\n" +
                "#3. Check(Google) whether the digital ocean servers are down or not.\n" +
                "#4. If none of above worked, please contact the main admin.\n" +
                "#5. Contact the developer if step 4 also failed.";
            }
            else
            {
                MessageBox.Show("Invalid input !", "Error");
                usrdb = "error";
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
