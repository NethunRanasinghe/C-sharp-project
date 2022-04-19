using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace C_sharp_project
{
    public partial class ProfitNloss : Form
    {
        public ProfitNloss()
        {
            InitializeComponent();
        }

        private void prftgn_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gentdy_Click(object sender, EventArgs e)
        {
            int x = 0;
            double ttlsell = 0;
            double ttlval=0;
            double ttlothrcsts = 0;
            double ytdsell=0;
            double ytdval=0;
            double ytdothrcsts = 0;
            DateTime dtn = DateTime.Now;
            string dtdo = dtn.ToString("d");
            string ydt=dtn.AddDays(-1).ToString("d");
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sandman\source\repos\C-sharp-project\C-sharp-project\bin\Debug\net5.0-windows\systmDB.mdf;Integrated Security=True;Connect Timeout=30");
               // String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                //String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                String sql = "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date='"+dtdo+"'ORDER BY profit DESC";
                //String sql2 = "SELECT * FROM sellinfo WHERE date='" + ydt + "'";
                String sql2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date='" + ydt + "'ORDER BY profit DESC";
                SqlDataAdapter da = new SqlDataAdapter("Select * From sellinfo WHERE date='" + dtdo + "'", connection);
                DataSet ds = new DataSet();
                int results = da.Fill(ds, "id");

                //before loop
                this.DataOrderCount.Text=results.ToString();
                // MessageBox.Show(results.ToString());
                using (SqlCommand command2 = new SqlCommand(sql2, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            ytdsell = ytdsell + (Convert.ToDouble(reader2["selling_price"]));
                            ytdval = ytdval + (Convert.ToDouble(reader2["value"]));
                            ytdothrcsts = ytdothrcsts + (Convert.ToDouble(reader2["other_costs"]));
                        }

                    }
                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double val = 0;
                            double sell = 0;
                            double profit = 0;

                            ttlsell = ttlsell + (Convert.ToDouble(reader["selling_price"]));
                            ttlval = ttlval + (Convert.ToDouble(reader["value"]));
                            ttlothrcsts = ttlothrcsts + (Convert.ToDouble(reader["other_costs"]));
                            x++;
                            switch(x)
                            {
                                case 1:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;                                
                                    this.r1c1.Text = Convert.ToString(reader["ID"]);
                                    this.r1c2.Text = Convert.ToString(reader["name"]);
                                    this.r1c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r1c4.Text = Convert.ToString(reader["profit"]); 
                                    //this.r1c4.Text = Convert.ToString("Rs " + profit); 
                                    this.rate1.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break; 

                                case 2:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r2c1.Text = Convert.ToString(reader["ID"]);
                                    this.r2c2.Text = Convert.ToString(reader["name"]);
                                    this.r2c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r2c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r2c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate2.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 3:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r3c1.Text = Convert.ToString(reader["ID"]);
                                    this.r3c2.Text = Convert.ToString(reader["name"]);
                                    this.r3c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r3c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r3c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate3.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 4:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r4c1.Text = Convert.ToString(reader["ID"]);
                                    this.r4c2.Text = Convert.ToString(reader["name"]);
                                    this.r4c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r4c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r4c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate4.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 5:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r5c1.Text = Convert.ToString(reader["ID"]);
                                    this.r5c2.Text = Convert.ToString(reader["name"]);
                                    this.r5c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r5c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r5c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate5.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                            }


                            //Console.WriteLine(" "+reader.GetValue(0)+" " + reader.GetValue(1)+" " + reader.GetValue(2) + " " + reader.GetValue(3) + " "+reader.GetValue(4) + " " );
                        }
                        double tdprft = ttlsell - (ttlval + ttlothrcsts);
                        double ytdprft = ytdsell - (ytdval + ytdothrcsts);
                        double tdrev = ttlsell - ttlval;
                        double ytdrev = ytdsell - ytdval;
                        double tdrevrt = Math.Round(((tdrev-ytdrev)/ytdrev)*100,2);
                        double tdprftrt = Math.Round(((tdprft - ytdprft) / ytdprft) * 100,2);                       
                        this.DataRev.Text = "Rs "+ Convert.ToString(ttlsell-ttlval);
                        this.DataProfit.Text = "Rs "+Convert.ToString(ttlsell - (ttlval + ttlothrcsts));
                        this.ttlrevrt.Text = "%"+Convert.ToString(tdrevrt);
                        this.ttlprftrt.Text = "%" + Convert.ToString(tdprftrt);
                                               
                    }
                    connection.Close();

                }

            }
            catch (SqlException ea)
            {
                Console.WriteLine(ea.ToString());
            }
        }

        private void genlstwk_Click(object sender, EventArgs e)
        {
            int x = 0;
            double ttlsell = 0;
            double ttlval = 0;
            double ttlothrcsts = 0;
            double ytdsell = 0;
            double ytdval = 0;
            double ytdothrcsts = 0;
            DateTime dtn = DateTime.Now;
            string dtdo = dtn.ToString("d");
            string ydt = dtn.AddDays(-6).ToString("d");
            string wbfr = dtn.AddDays(-12).ToString("d");
           

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sandman\source\repos\C-sharp-project\C-sharp-project\bin\Debug\net5.0-windows\systmDB.mdf;Integrated Security=True;Connect Timeout=30");
                // String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                //String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                String sql = "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '"+ydt+"' AND '"+dtdo+"' ORDER BY profit DESC";
                //String sql2 = "SELECT * FROM sellinfo WHERE date='" + ydt + "'";
                String sql2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '"+wbfr+"' AND '"+ydt+"'  ORDER BY profit DESC";
                SqlDataAdapter da = new SqlDataAdapter("Select * From sellinfo WHERE date BETWEEN '" + ydt + "' AND '" + dtdo + "' ", connection);
                DataSet ds = new DataSet();
                int results = da.Fill(ds, "id");

                //before loop
                this.DataOrderCount.Text = results.ToString();
                // MessageBox.Show(results.ToString());
                using (SqlCommand command2 = new SqlCommand(sql2, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            ytdsell = ytdsell + (Convert.ToDouble(reader2["selling_price"]));
                            ytdval = ytdval + (Convert.ToDouble(reader2["value"]));
                            ytdothrcsts = ytdothrcsts + (Convert.ToDouble(reader2["other_costs"]));
                        }

                    }
                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double val = 0;
                            double sell = 0;
                            double profit = 0;

                            ttlsell = ttlsell + (Convert.ToDouble(reader["selling_price"]));
                            ttlval = ttlval + (Convert.ToDouble(reader["value"]));
                            ttlothrcsts = ttlothrcsts + (Convert.ToDouble(reader["other_costs"]));
                            x++;
                            switch (x)
                            {
                                case 1:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r1c1.Text = Convert.ToString(reader["ID"]);
                                    this.r1c2.Text = Convert.ToString(reader["name"]);
                                    this.r1c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r1c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r1c4.Text = Convert.ToString("Rs " + profit); 
                                    this.rate1.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 2:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r2c1.Text = Convert.ToString(reader["ID"]);
                                    this.r2c2.Text = Convert.ToString(reader["name"]);
                                    this.r2c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r2c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r2c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate2.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 3:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r3c1.Text = Convert.ToString(reader["ID"]);
                                    this.r3c2.Text = Convert.ToString(reader["name"]);
                                    this.r3c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r3c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r3c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate3.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 4:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r4c1.Text = Convert.ToString(reader["ID"]);
                                    this.r4c2.Text = Convert.ToString(reader["name"]);
                                    this.r4c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r4c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r4c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate4.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 5:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r5c1.Text = Convert.ToString(reader["ID"]);
                                    this.r5c2.Text = Convert.ToString(reader["name"]);
                                    this.r5c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r5c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r5c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate5.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                            }


                            //Console.WriteLine(" "+reader.GetValue(0)+" " + reader.GetValue(1)+" " + reader.GetValue(2) + " " + reader.GetValue(3) + " "+reader.GetValue(4) + " " );
                        }
                        double tdprft = ttlsell - (ttlval + ttlothrcsts);
                        double ytdprft = ytdsell - (ytdval + ytdothrcsts);
                        double tdrev = ttlsell - ttlval;
                        double ytdrev = ytdsell - ytdval;
                        double tdrevrt = Math.Round(((tdrev - ytdrev) / ytdrev) * 100, 2);
                        double tdprftrt = Math.Round(((tdprft - ytdprft) / ytdprft) * 100, 2);
                        this.DataRev.Text = "Rs " + Convert.ToString(ttlsell - ttlval);
                        this.DataProfit.Text = "Rs " + Convert.ToString(ttlsell - (ttlval + ttlothrcsts));
                        this.ttlrevrt.Text = "%" + Convert.ToString(tdrevrt);
                        this.ttlprftrt.Text = "%" + Convert.ToString(tdprftrt);

                    }
                    connection.Close();

                }

            }
            catch (SqlException ea)
            {
                Console.WriteLine(ea.ToString());
            }
        }

        private void genthsmnth_Click(object sender, EventArgs e)
        {
            int x = 0;
            double ttlsell = 0;
            double ttlval = 0;
            double ttlothrcsts = 0;
            double ytdsell = 0;
            double ytdval = 0;
            double ytdothrcsts = 0;
            DateTime dtn = DateTime.Now;
            int dtdo = Convert.ToInt32(dtn.Month);
            int ydt = Convert.ToInt32(dtn.AddMonths(-1).Month);
 

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sandman\source\repos\C-sharp-project\C-sharp-project\bin\Debug\net5.0-windows\systmDB.mdf;Integrated Security=True;Connect Timeout=30");
                // String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                //String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                String sql = "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '"+dtdo+"' ORDER BY profit DESC";
                //String sql2 = "SELECT * FROM sellinfo WHERE date='" + ydt + "'";
                String sql2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '"+ydt+"'  ORDER BY profit DESC";
                SqlDataAdapter da = new SqlDataAdapter("Select * From sellinfo WHERE Month(date) = '" + dtdo + "'", connection);
                DataSet ds = new DataSet();
                int results = da.Fill(ds, "id");

                //before loop
                this.DataOrderCount.Text = results.ToString();
                // MessageBox.Show(results.ToString());
                using (SqlCommand command2 = new SqlCommand(sql2, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            ytdsell = ytdsell + (Convert.ToDouble(reader2["selling_price"]));
                            ytdval = ytdval + (Convert.ToDouble(reader2["value"]));
                            ytdothrcsts = ytdothrcsts + (Convert.ToDouble(reader2["other_costs"]));
                        }

                    }
                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double val = 0;
                            double sell = 0;
                            double profit = 0;

                            ttlsell = ttlsell + (Convert.ToDouble(reader["selling_price"]));
                            ttlval = ttlval + (Convert.ToDouble(reader["value"]));
                            ttlothrcsts = ttlothrcsts + (Convert.ToDouble(reader["other_costs"]));
                            x++;
                            switch (x)
                            {
                                case 1:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r1c1.Text = Convert.ToString(reader["ID"]);
                                    this.r1c2.Text = Convert.ToString(reader["name"]);
                                    this.r1c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r1c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r1c4.Text = Convert.ToString("Rs " + profit); 
                                    this.rate1.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 2:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r2c1.Text = Convert.ToString(reader["ID"]);
                                    this.r2c2.Text = Convert.ToString(reader["name"]);
                                    this.r2c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r2c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r2c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate2.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 3:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r3c1.Text = Convert.ToString(reader["ID"]);
                                    this.r3c2.Text = Convert.ToString(reader["name"]);
                                    this.r3c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r3c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r3c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate3.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 4:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r4c1.Text = Convert.ToString(reader["ID"]);
                                    this.r4c2.Text = Convert.ToString(reader["name"]);
                                    this.r4c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r4c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r4c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate4.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 5:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r5c1.Text = Convert.ToString(reader["ID"]);
                                    this.r5c2.Text = Convert.ToString(reader["name"]);
                                    this.r5c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r5c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r5c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate5.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                            }


                            //Console.WriteLine(" "+reader.GetValue(0)+" " + reader.GetValue(1)+" " + reader.GetValue(2) + " " + reader.GetValue(3) + " "+reader.GetValue(4) + " " );
                        }
                        double tdprft = ttlsell - (ttlval + ttlothrcsts);
                        double ytdprft = ytdsell - (ytdval + ytdothrcsts);
                        double tdrev = ttlsell - ttlval;
                        double ytdrev = ytdsell - ytdval;
                        double tdrevrt = Math.Round(((tdrev - ytdrev) / ytdrev) * 100, 2);
                        double tdprftrt = Math.Round(((tdprft - ytdprft) / ytdprft) * 100, 2);
                        this.DataRev.Text = "Rs " + Convert.ToString(ttlsell - ttlval);
                        this.DataProfit.Text = "Rs " + Convert.ToString(ttlsell - (ttlval + ttlothrcsts));
                        this.ttlrevrt.Text = "%" + Convert.ToString(tdrevrt);
                        this.ttlprftrt.Text = "%" + Convert.ToString(tdprftrt);

                    }
                    connection.Close();

                }

            }
            catch (SqlException ea)
            {
                Console.WriteLine(ea.ToString());
            }
        }

        private void genlstmnth_Click(object sender, EventArgs e)
        {
            int x = 0;
            double ttlsell = 0;
            double ttlval = 0;
            double ttlothrcsts = 0;
            double ytdsell = 0;
            double ytdval = 0;
            double ytdothrcsts = 0;
            DateTime dtn = DateTime.Now;
            int dtdo = Convert.ToInt32(dtn.AddMonths(-1).Month);
            int ydt = Convert.ToInt32(dtn.AddMonths(-2).Month);


            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sandman\source\repos\C-sharp-project\C-sharp-project\bin\Debug\net5.0-windows\systmDB.mdf;Integrated Security=True;Connect Timeout=30");
                // String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                //String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                String sql = "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '" + dtdo + "' ORDER BY profit DESC";
                //String sql2 = "SELECT * FROM sellinfo WHERE date='" + ydt + "'";
                String sql2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '" + ydt + "'  ORDER BY profit DESC";
                SqlDataAdapter da = new SqlDataAdapter("Select * From sellinfo WHERE Month(date) = '" + dtdo + "'", connection);
                DataSet ds = new DataSet();
                int results = da.Fill(ds, "id");

                //before loop
                this.DataOrderCount.Text = results.ToString();
                // MessageBox.Show(results.ToString());
                using (SqlCommand command2 = new SqlCommand(sql2, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            ytdsell = ytdsell + (Convert.ToDouble(reader2["selling_price"]));
                            ytdval = ytdval + (Convert.ToDouble(reader2["value"]));
                            ytdothrcsts = ytdothrcsts + (Convert.ToDouble(reader2["other_costs"]));
                        }

                    }
                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double val = 0;
                            double sell = 0;
                            double profit = 0;

                            ttlsell = ttlsell + (Convert.ToDouble(reader["selling_price"]));
                            ttlval = ttlval + (Convert.ToDouble(reader["value"]));
                            ttlothrcsts = ttlothrcsts + (Convert.ToDouble(reader["other_costs"]));
                            x++;
                            switch (x)
                            {
                                case 1:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r1c1.Text = Convert.ToString(reader["ID"]);
                                    this.r1c2.Text = Convert.ToString(reader["name"]);
                                    this.r1c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r1c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r1c4.Text = Convert.ToString("Rs " + profit); 
                                    this.rate1.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 2:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r2c1.Text = Convert.ToString(reader["ID"]);
                                    this.r2c2.Text = Convert.ToString(reader["name"]);
                                    this.r2c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r2c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r2c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate2.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 3:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r3c1.Text = Convert.ToString(reader["ID"]);
                                    this.r3c2.Text = Convert.ToString(reader["name"]);
                                    this.r3c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r3c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r3c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate3.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 4:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r4c1.Text = Convert.ToString(reader["ID"]);
                                    this.r4c2.Text = Convert.ToString(reader["name"]);
                                    this.r4c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r4c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r4c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate4.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 5:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r5c1.Text = Convert.ToString(reader["ID"]);
                                    this.r5c2.Text = Convert.ToString(reader["name"]);
                                    this.r5c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r5c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r5c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate5.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                            }


                            //Console.WriteLine(" "+reader.GetValue(0)+" " + reader.GetValue(1)+" " + reader.GetValue(2) + " " + reader.GetValue(3) + " "+reader.GetValue(4) + " " );
                        }
                        double tdprft = ttlsell - (ttlval + ttlothrcsts);
                        double ytdprft = ytdsell - (ytdval + ytdothrcsts);
                        double tdrev = ttlsell - ttlval;
                        double ytdrev = ytdsell - ytdval;
                        double tdrevrt = Math.Round(((tdrev - ytdrev) / ytdrev) * 100, 2);
                        double tdprftrt = Math.Round(((tdprft - ytdprft) / ytdprft) * 100, 2);
                        this.DataRev.Text = "Rs " + Convert.ToString(ttlsell - ttlval);
                        this.DataProfit.Text = "Rs " + Convert.ToString(ttlsell - (ttlval + ttlothrcsts));
                        this.ttlrevrt.Text = "%" + Convert.ToString(tdrevrt);
                        this.ttlprftrt.Text = "%" + Convert.ToString(tdprftrt);

                    }
                    connection.Close();

                }

            }
            catch (SqlException ea)
            {
                Console.WriteLine(ea.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int x = 0;
            double ttlsell = 0;
            double ttlval = 0;
            double ttlothrcsts = 0;
            double ytdsell = 0;
            double ytdval = 0;
            double ytdothrcsts = 0;
            string dtleft = dateTimePicker1.Value.ToString("d");
            string dtright = dateTimePicker2.Value.ToString("d");

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sandman\source\repos\C-sharp-project\C-sharp-project\bin\Debug\net5.0-windows\systmDB.mdf;Integrated Security=True;Connect Timeout=30");
                // String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                //String sql = "SELECT * FROM sellinfo WHERE date='"+dtdo+"'";
                String sql = "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '" + dtleft + "' AND '" + dtright + "' ORDER BY profit DESC";
                //String sql2 = "SELECT * FROM sellinfo WHERE date='" + ydt + "'";
                String sql2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '" + dtleft + "' AND '" + dtright + "'  ORDER BY profit DESC";
                SqlDataAdapter da = new SqlDataAdapter("Select * From sellinfo WHERE date BETWEEN '" + dtleft + "' AND '" + dtright + "' ", connection);
                DataSet ds = new DataSet();
                int results = da.Fill(ds, "id");

                //before loop
                this.DataOrderCount.Text = results.ToString();
                // MessageBox.Show(results.ToString());
                using (SqlCommand command2 = new SqlCommand(sql2, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            ytdsell = ytdsell + (Convert.ToDouble(reader2["selling_price"]));
                            ytdval = ytdval + (Convert.ToDouble(reader2["value"]));
                            ytdothrcsts = ytdothrcsts + (Convert.ToDouble(reader2["other_costs"]));
                        }

                    }
                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double val = 0;
                            double sell = 0;
                            double profit = 0;

                            ttlsell = ttlsell + (Convert.ToDouble(reader["selling_price"]));
                            ttlval = ttlval + (Convert.ToDouble(reader["value"]));
                            ttlothrcsts = ttlothrcsts + (Convert.ToDouble(reader["other_costs"]));
                            x++;

                            switch (x)
                            {
                                case 1:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r1c1.Text = Convert.ToString(reader["ID"]);
                                    this.r1c2.Text = Convert.ToString(reader["name"]);
                                    this.r1c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r1c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r1c4.Text = Convert.ToString("Rs " + profit); 
                                    this.rate1.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 2:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r2c1.Text = Convert.ToString(reader["ID"]);
                                    this.r2c2.Text = Convert.ToString(reader["name"]);
                                    this.r2c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r2c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r2c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate2.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 3:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r3c1.Text = Convert.ToString(reader["ID"]);
                                    this.r3c2.Text = Convert.ToString(reader["name"]);
                                    this.r3c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r3c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r3c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate3.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 4:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r4c1.Text = Convert.ToString(reader["ID"]);
                                    this.r4c2.Text = Convert.ToString(reader["name"]);
                                    this.r4c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r4c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r4c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate4.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                                case 5:
                                    val = Convert.ToDouble(reader["value"]);
                                    sell = Convert.ToDouble(reader["selling_price"]);
                                    profit = sell - val;
                                    this.r5c1.Text = Convert.ToString(reader["ID"]);
                                    this.r5c2.Text = Convert.ToString(reader["name"]);
                                    this.r5c3.Text = Convert.ToString(reader["date"])!.Substring(0, 10);
                                    this.r5c4.Text = Convert.ToString(reader["profit"]);
                                    //this.r5c4.Text = Convert.ToString("Rs " + profit);
                                    this.rate5.Text = Convert.ToString((sell - val) / 100 + "%");
                                    break;

                            }


                            //Console.WriteLine(" "+reader.GetValue(0)+" " + reader.GetValue(1)+" " + reader.GetValue(2) + " " + reader.GetValue(3) + " "+reader.GetValue(4) + " " );
                        }
                        double tdprft = ttlsell - (ttlval + ttlothrcsts);
                        double ytdprft = ytdsell - (ytdval + ytdothrcsts);
                        double tdrev = ttlsell - ttlval;
                        double ytdrev = ytdsell - ytdval;
                        double tdrevrt = Math.Round(((tdrev - ytdrev) / ytdrev) * 100, 2);
                        double tdprftrt = Math.Round(((tdprft - ytdprft) / ytdprft) * 100, 2);
                        this.DataRev.Text = "Rs " + Convert.ToString(ttlsell - ttlval);
                        this.DataProfit.Text = "Rs " + Convert.ToString(ttlsell - (ttlval + ttlothrcsts));
                        this.ttlrevrt.Text = "%" + Convert.ToString(tdrevrt);
                        this.ttlprftrt.Text = "%" + Convert.ToString(tdprftrt);

                    }
                    connection.Close();

                }

            }
            catch (SqlException ea)
            {
                Console.WriteLine(ea.ToString());
            }




            if () ;
        }
    }
}
