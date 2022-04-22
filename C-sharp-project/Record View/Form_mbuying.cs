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
    public partial class Form_mbuying : Form
    {
        public Form_mbuying()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LBL_buying.Text = "RS._______";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_mbuymain_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_selectionmenu = new form_selectionmenu();
            form_selectionmenu.Show();
            //SAHANSAGE selection main menu eka danna
        }

        private void BTN_mbuyback_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var SCNDfrm = new SCNDfrm();
            //SCNDfrm.Show();
        //kalin form eka dnne
        }
    }
}
