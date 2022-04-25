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
            Customer_Data_SQL customer_Data_SQL = new Customer_Data_SQL();
            customer_Data_SQL.set_cnic(Convert.ToInt32(this.nictxtbox.Text));
            sql_execute(customer_Data_SQL.get_cstdatasqlnic());
        }
        private void sql_execute(string sqlqry)
        {
            DBConn dBConn = new DBConn();
            using (MySqlConnection con = new MySqlConnection(dBConn.getdbconn()))
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
            Customer_Data_SQL customer_Data_SQL = new Customer_Data_SQL();
            customer_Data_SQL.set_cprv(this.prvnctxtbx.Text);
            sql_execute(customer_Data_SQL.get_cstdatasqlcprv());

        }
    }
}