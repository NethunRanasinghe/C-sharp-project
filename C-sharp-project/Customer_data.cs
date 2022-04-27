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
    public partial class Customer_data : Form
    {
        public Customer_data()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersHeight = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.nictxtbox.Text!= "")
            {
                Customer_Data_SQL customer_Data_SQL = new Customer_Data_SQL();
                customer_Data_SQL.set_cnic(this.nictxtbox.Text);
                customer_Data_SQL.set_cstdatasqlnic();
                sql_execute(customer_Data_SQL.get_cstdatasqlnic());
            }
        }
        private void sql_execute(string sqlqry)
        {
            Select_DBConn dBConn = new Select_DBConn();
            using (MySqlConnection con = new MySqlConnection(dBConn.GetDBConn()))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlqry, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.prvnctxtbx.Text != "")
            {
                Customer_Data_SQL customer_Data_SQL = new Customer_Data_SQL();
                customer_Data_SQL.set_cprv(this.prvnctxtbx.Text);
                customer_Data_SQL.set_cstdatasqlcprv();
                sql_execute(customer_Data_SQL.get_cstdatasqlcprv());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.phntxtbx.Text != "" && (this.phntxtbx.Text.All(char.IsDigit)) == true)
            {
                Customer_Data_SQL customer_Data_SQL = new Customer_Data_SQL();
                customer_Data_SQL.set_cphno(Convert.ToInt32(this.phntxtbx.Text));
                customer_Data_SQL.set_cstdatasqlphno();
                sql_execute(customer_Data_SQL.get_cstdatasqlphno());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.fntxtbx.Text != "" || this.lntxtbx.Text != "")
            {
                Customer_Data_SQL customer_Data_SQL = new Customer_Data_SQL();
                customer_Data_SQL.set_cnm(this.fntxtbx.Text, this.lntxtbx.Text);
                customer_Data_SQL.set_cstdatasqlname();
                sql_execute(customer_Data_SQL.get_cstdatasqlname());
            }
        }

    }
}
//&& (this.nictxtbox.Text.All(char.IsDigit))==true