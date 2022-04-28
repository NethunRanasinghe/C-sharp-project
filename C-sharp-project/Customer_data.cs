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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void jmp_user_reg_Click(object sender, EventArgs e)
        {
            user_reg user_Reg = new user_reg();
            this.Hide();
            user_Reg.Show();
        }

        private void jmp_to_prftnlss_Click(object sender, EventArgs e)
        {
            ProfitNloss profitNloss = new ProfitNloss();
            this.Hide();
            profitNloss.Show();
        }

        private void jmp_othr_transaction_Click(object sender, EventArgs e)
        {
            ACother2 aCother2 = new ACother2();
            this.Hide();
            aCother2.Show();
        }

        private void jmp_buyform_Click(object sender, EventArgs e)
        {
            BUYfrm bUYfrm = new BUYfrm();
            this.Hide();
            bUYfrm.Show();

        }

        private void jmp_monthly_buy_Click(object sender, EventArgs e)
        {
            Form_mbuying form_Mbuying = new Form_mbuying();
            this.Hide();
            form_Mbuying.Show();
        }

        private void jmp_monthly_sell_Click(object sender, EventArgs e)
        {
            Form_mselling form_Mselling = new Form_mselling();
            this.Hide();
            form_Mselling.Show();
        }

        private void jmp_sales_Click(object sender, EventArgs e)
        {
            form_sales form_Sales = new form_sales();
            this.Hide();
            form_Sales.Show();
        }
    }
}