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
    public partial class Form_mselling : Form
    {
        public Form_mselling()
        {
            InitializeComponent();
        }

        private void BTN_sellingclear_Click(object sender, EventArgs e)
        {
            LBL_sellings.Text = "RS._______";
        }

        private void BTN_mbuyback_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var SCNDfrm = new SCNDfrm();
            //SCNDfrm.Show();
            //kalin form eka dnne
        }

        private void BTN_mbuymain_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_selectionmenu = new form_selectionmenu();
           form_selectionmenu.Show();
            //SAHANSAGE selection main menu eka danna

        }

        private void Form_mselling_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
