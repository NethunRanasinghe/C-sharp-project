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
//using System.Data.SqlClient;



namespace C_sharp_project
{
    public partial class ProfitNloss : Form
    {
        ProfitNloss_SQL objv = new ProfitNloss_SQL();

        public ProfitNloss()
        {
            InitializeComponent();
            textrest();
            strctre(objv.tdy_sql1(), objv.tdy_sql2(), objv.tdy_sql3(), "tdy");
            panel1.Visible = false;
        }

        private void prftgn_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gentdy_Click(object sender, EventArgs e)
        {
            textrest();
            strctre(objv.tdy_sql1(),objv.tdy_sql2(),objv.tdy_sql3(),"tdy");
        }

        private void genlstwk_Click(object sender, EventArgs e)
        {
            textrest();
            strctre(objv.lst7dys_sql1(), objv.lst7dys_sql2(), objv.lst7dys_sql3(),"lstwk");

        }

        private void genthsmnth_Click(object sender, EventArgs e)
        {
            textrest();
            strctre(objv.thsmnth_sql1(), objv.thsmnth_sql2(), objv.thsmnth_sql3(),"thsmnth");
        }

        private void genlstmnth_Click(object sender, EventArgs e)
        {
            textrest();
            strctre(objv.lstmnth_sql1(), objv.lstmnth_sql2(), objv.lstmnth_sql3(),"lstmnth");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textrest();
            objv.setdatpicker(this.dateTimePicker1, this.dateTimePicker2);
            objv.set_cstmsql1();
            objv.set_cstmsql2();
            objv.set_cstmsql3();
            strctre(objv.cstm_sql1(), objv.cstm_sql2(), objv.cstm_sql3(),"cstm");

        }

        private void strctre(string sqlqry1, string sqlqry2,string sqlqry3,string bttn)
        {
            int x = 0;
            double ttlsell = 0;
            double ttlval = 0;
            double ttlothrcsts = 0;
            double ytdsell = 0;
            double ytdval = 0;
            double ytdothrcsts = 0;
            Select_DBConn obj = new Select_DBConn();
            MySqlConnection connection = new MySqlConnection(obj.GetDBConn());
            MySqlDataAdapter da = new MySqlDataAdapter(sqlqry3, connection);
            DataSet ds = new DataSet();
            try
            {
                //con open
                connection.Open();

                int results = da.Fill(ds, "id");
                this.DataOrderCount.Text = results.ToString();
                using (MySqlCommand command2 = new MySqlCommand(sqlqry2, connection))
                {
                    using (MySqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            ytdsell = ytdsell + (Convert.ToDouble(reader2["selling_price"]));
                            ytdval = ytdval + (Convert.ToDouble(reader2["value"]));
                            ytdothrcsts = ytdothrcsts + (Convert.ToDouble(reader2["additional_charges"]));
                        }

                    }
                }

                using (MySqlCommand command = new MySqlCommand(sqlqry1, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double val = 0;
                            double sell = 0;
                            double profit = 0;

                            ttlsell = ttlsell + (Convert.ToDouble(reader["selling_price"]));
                            ttlval = ttlval + (Convert.ToDouble(reader["value"]));
                            ttlothrcsts = ttlothrcsts + (Convert.ToDouble(reader["additional_charges"]));
                            x++;
                            switch (x)
                            {
                                case 1:
                                    val = Convert.ToDouble(reader["value"])+ Convert.ToDouble(reader["additional_charges"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r1c1.Text = Convert.ToString(reader["ID"]);
                                    this.r1c2.Text = Convert.ToString(reader["product_name"]);
                                    this.r1c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r1c4.Text = "Rs " + Convert.ToString(reader["profit"]);
                                    this.rate1.Text = Convert.ToString(Math.Round(((sell - val) / val) * 100, 2) + "%");
                                    break;

                                case 2:
                                    val = Convert.ToDouble(reader["value"]) + Convert.ToDouble(reader["additional_charges"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r2c1.Text = Convert.ToString(reader["ID"]);
                                    this.r2c2.Text = Convert.ToString(reader["product_name"]);
                                    this.r2c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r2c4.Text = "Rs "+Convert.ToString(reader["profit"]);
                                    this.rate2.Text = Convert.ToString(Math.Round(((sell - val) / val) * 100, 2) + "%");
                                    break;

                                case 3:
                                    val = Convert.ToDouble(reader["value"]) + Convert.ToDouble(reader["additional_charges"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r3c1.Text = Convert.ToString(reader["ID"]);
                                    this.r3c2.Text = Convert.ToString(reader["product_name"]);
                                    this.r3c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r3c4.Text = "Rs " + Convert.ToString(reader["profit"]);
                                    this.rate3.Text = Convert.ToString(Math.Round(((sell - val) / val) * 100, 2) + "%");
                                    break;

                                case 4:
                                    val = Convert.ToDouble(reader["value"]) + Convert.ToDouble(reader["additional_charges"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r4c1.Text = Convert.ToString(reader["ID"]);
                                    this.r4c2.Text = Convert.ToString(reader["product_name"]);
                                    this.r4c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r4c4.Text = "Rs " + Convert.ToString(reader["profit"]);
                                    this.rate4.Text = Convert.ToString(Math.Round(((sell - val) / val) * 100, 2) + "%");
                                    break;

                                case 5:
                                    val = Convert.ToDouble(reader["value"]) + Convert.ToDouble(reader["additional_charges"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r5c1.Text = Convert.ToString(reader["ID"]);
                                    this.r5c2.Text = Convert.ToString(reader["product_name"]);
                                    this.r5c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r5c4.Text = "Rs " + Convert.ToString(reader["profit"]);
                                    this.rate5.Text = Convert.ToString(Math.Round(((sell - val) / val)*100,2) + "%");
                                    break;

                            }
                        }
                        //con close
                        connection.Close();

                        double tdprft = ttlsell - (ttlval + ttlothrcsts);
                        double ytdprft = ytdsell - (ytdval + ytdothrcsts);
                        double tdrev = ttlsell - ttlval;
                        double ytdrev = ytdsell - ytdval;
                        double tdrevrt = Math.Round(((tdrev - ytdrev) / ytdrev) * 100, 2);
                        double tdprftrt = Math.Round(((tdprft - ytdprft) / ytdprft) * 100, 2);
                        this.DataRev.Text = "Rs " + Convert.ToString(ttlsell);
                        this.DataProfit.Text = "Rs " + Convert.ToString(ttlsell - (ttlval + ttlothrcsts));
                        if(bttn!="cstm")
                        {
                            if(tdrevrt>0)
                            {
                                this.ttlrevrt.ForeColor=Color.Lime;
                                this.ttlrevrt.Text =  "+"+ Convert.ToString(tdrevrt)+ "%";
                            }
                            else
                            {
                                this.ttlrevrt.ForeColor = Color.Red;
                                this.ttlrevrt.Text = Convert.ToString(tdrevrt) + "%";
                            }
                            if(tdprftrt>0)
                            {
                                this.ttlprftrt.ForeColor = Color.Lime;
                                this.ttlprftrt.Text = "+" + Convert.ToString(tdprftrt) + "%";
                            }
                            else
                            {
                                this.ttlprftrt.ForeColor = Color.Red;
                                this.ttlprftrt.Text = Convert.ToString(tdprftrt) + "%";
                            }
                        }
                        else if(bttn=="cstm")
                        {
                            this.ttlrevrt.Text = "";
                            this.ttlprftrt.Text = "";
                        }
                        

                    }
                }

            }
            catch (MySqlException ea)
            {
                Console.WriteLine(ea.ToString());
            }

        }

        private void textrest()
        {
            this.r1c1.Text = "";
            this.r1c2.Text = "";
            this.r1c3.Text = "";
            this.r1c4.Text = "";
            this.rate1.Text = "";
            this.r2c1.Text = "";
            this.r2c2.Text = "";
            this.r2c3.Text = "";
            this.r2c4.Text = "";
            this.rate2.Text = "";
            this.r3c1.Text = "";
            this.r3c2.Text = "";
            this.r3c3.Text = "";
            this.r3c4.Text = "";
            this.rate3.Text = "";
            this.r4c1.Text = "";
            this.r4c2.Text = "";
            this.r4c3.Text = "";
            this.r4c4.Text = "";
            this.rate4.Text = "";
            this.r5c1.Text = "";
            this.r5c2.Text = "";
            this.r5c3.Text = "";
            this.r5c4.Text = "";
            this.rate5.Text = "";
            this.DataOrderCount.Text = ""; ;
            this.ttlrevrt.Text = "";
            this.ttlprftrt.Text = "";
            this.DataRev.Text = "";
            this.DataProfit.Text = "";

        }

        private void jmp_user_reg_Click(object sender, EventArgs e)
        {
            user_reg user_Reg = new user_reg();
            this.Hide();
            user_Reg.Show();
        }

        private void jmp_to_customer_data_Click(object sender, EventArgs e)
        {
            Customer_data customer_Data = new Customer_data();
            this.Hide();
            customer_Data.Show();

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

        private void menu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            menu.Visible = false;
        }

        private void menu_close_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            menu.Visible = true;
        }
    }
}
