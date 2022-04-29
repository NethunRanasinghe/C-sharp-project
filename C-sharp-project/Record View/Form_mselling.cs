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
    public partial class Form_mselling : Form
    {
        int month_num = 0;
        string connection_string = Choose_Database.usrdb;

        public Form_mselling()
        {
            InitializeComponent();
        }

        private void record_show()
        {
            month_num = Convert.ToDateTime(sell_date.Value).Month;
            string log_query = "SELECT * FROM `salesrecords` WHERE MONTH(DATE) = '"+month_num+"';";

            MySqlDataAdapter adapter = new MySqlDataAdapter(log_query, connection_string);
            DataTable table = new DataTable();
            adapter.Fill(table);

            sell_record.DataSource = table;
        }

        private void Form_mselling_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acc_form objacfrm = new Acc_form();
            objacfrm.Show();
        }

        private void sell_btnsub_Click(object sender, EventArgs e)
        {
            record_show();
        }

        private void sell_btnreset_Click(object sender, EventArgs e)
        {
            sell_record.DataSource = null;
        }
    }
}
