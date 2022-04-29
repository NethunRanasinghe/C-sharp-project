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
    public partial class Form_mbuying : Form
    {
        string connection_string = Choose_Database.usrdb;
        int month_num = 0;

        public Form_mbuying()
        {
            InitializeComponent();
        }

        private void record_show()
        {
            try
            {
                month_num = Convert.ToDateTime(buy_date.Value).Month;
                string log_query = "SELECT * FROM `buy` WHERE MONTH(DATE) = '" + month_num + "';";

                MySqlDataAdapter adapter = new MySqlDataAdapter(log_query, connection_string);
                DataTable table = new DataTable();
                adapter.Fill(table);

                buy_record.DataSource = table;
            }catch (Exception ex)
            {
                MessageBox.Show("Error :- " +ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acc_form objacfrm = new Acc_form();
            objacfrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buy_btnsub_Click(object sender, EventArgs e)
        {
            record_show();
        }

        private void buy_btnre_Click(object sender, EventArgs e)
        {
            buy_record.DataSource = null;
        }
    }
}
