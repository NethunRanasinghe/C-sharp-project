﻿ using System;
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
    public partial class form_selectionmenu : Form
    {
        int parse = 0;
    /*
        //fields
        private int borderRadius = 30;
        private int bordersize = 2;
        private Color borderColor = Color.RoyalBlue;

        //Constructor
    */
        public form_selectionmenu()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Padding = new Padding(bordersize);
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            selection_usr.Text = login_form.passingText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_sales_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_menu_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_sales = new form_sales();
            form_sales.Show();
        }

        private void btn_buying_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BUYfrm  = new BUYfrm();
            BUYfrm.Show();
        }

        private void btn_othersales_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OTHERexp = new OTHERexp();
            OTHERexp.Show();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
           // this.Hide();
             //var Intermediate  = new Intermediate();
            //Intermediate.Show();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var WDlst = new WDlst();
            //WDlst.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login_form = new login_form();
            login_form.Show();

        }
    }
}