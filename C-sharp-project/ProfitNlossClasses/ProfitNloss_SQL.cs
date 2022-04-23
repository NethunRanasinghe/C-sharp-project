using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_project
{
    internal class ProfitNloss_SQL
    {
        //today
        readonly private string tdy_sqlqry1= "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date='" + DateTime.Now.ToString("yyyy-MM-dd") + "'ORDER BY profit DESC";
        readonly private string tdy_sqlqry2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date='" + DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + "'ORDER BY profit DESC";
        readonly private string tdy_sqlqry3 = "Select * From sellinfo WHERE date='" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
        
        public string tdy_sql1()
         {
             return tdy_sqlqry1;
         }
         public string tdy_sql2()
         {
             return tdy_sqlqry2; 
         }
         public string tdy_sql3()
         {
             return tdy_sqlqry3;
         }


        //last 7 days
        readonly private string lst7dys_sqlqry1= "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '" + DateTime.Now.AddDays(-6).ToString("d") + "' AND '" + DateTime.Now.ToString("d") + "' ORDER BY profit DESC";
        readonly private string lst7dys_sqlqry2= "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '" + DateTime.Now.AddDays(-12).ToString("d") + "' AND '" + DateTime.Now.AddDays(-6).ToString("d") + "'  ORDER BY profit DESC";
        readonly private string lst7dys_sqlqry3= "Select * From sellinfo WHERE date BETWEEN '" + DateTime.Now.AddDays(-6).ToString("d") + "' AND '" + DateTime.Now.ToString("d") + "' ";

        public string lst7dys_sql1()
        {
            return lst7dys_sqlqry1;
        }
        public string lst7dys_sql2()
        {
            return lst7dys_sqlqry2;
        }
        public string lst7dys_sql3()
        {
            return lst7dys_sqlqry3;
        }


        //this month
        readonly private string thsmnth_sqlqry1 = "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '" + Convert.ToInt32(DateTime.Now.Month) + "' ORDER BY profit DESC";
        readonly private string thsmnth_sqlqry2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '" + Convert.ToInt32(DateTime.Now.AddMonths(-1).Month) + "'  ORDER BY profit DESC";
        readonly private string thsmnth_sqlqry3= "Select * From sellinfo WHERE Month(date) = '" + Convert.ToInt32(DateTime.Now.Month) + "'";

        public string thsmnth_sql1()
        {
            return thsmnth_sqlqry1;
        }
        public string thsmnth_sql2()
        {
            return thsmnth_sqlqry2;
        }
        public string thsmnth_sql3()
        {
            return thsmnth_sqlqry3;
        }

        //last month
        readonly private string lstmnth_sqlqry1= "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '" + Convert.ToInt32(DateTime.Now.AddMonths(-1).Month) + "' ORDER BY profit DESC";
        readonly private string lstmnth_sqlqry2= "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE DATEPART(month, date) = '" + Convert.ToInt32(DateTime.Now.AddMonths(-2).Month) + "'  ORDER BY profit DESC";
        readonly private string lstmnth_sqlqry3= "Select * From sellinfo WHERE Month(date) = '" + Convert.ToInt32(DateTime.Now.AddMonths(-1).Month) + "'";

        public string lstmnth_sql1()
        {
            return lstmnth_sqlqry1;
        }
        public string lstmnth_sql2()
        {
            return lstmnth_sqlqry2;
        }
        public string lstmnth_sql3()
        {
            return lstmnth_sqlqry3;
        }


        //custom date
        private string datepicker1="";
        private string datepicker2="";
        public void setdatpicker(string dt1,string dt2)
        {
            datepicker1 = dt1;
            datepicker2 = dt2;
        }

         private string cstm_sqlqry1 = "";
         private string cstm_sqlqry2 = "";
         private string cstm_sqlqry3 = "";

         public void set_cstmsql1()
         {
            cstm_sqlqry1 = "SELECT id,name,value,selling_price,date,other_costs,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '" + datepicker1 + "' AND '" + datepicker2 + "' ORDER BY profit DESC";
         }
        public void set_cstmsql2()
        {
            cstm_sqlqry2 = "SELECT id,name,value,selling_price,other_costs,date,selling_price-(value+other_costs) AS profit FROM sellinfo WHERE date BETWEEN '" + datepicker1 + "' AND '" + datepicker2 + "'  ORDER BY profit DESC";
        }
        public void set_cstmsql3()
        {
            cstm_sqlqry3 = "Select * From sellinfo WHERE date BETWEEN '" + datepicker1 + "' AND '" + datepicker2 + "' ";
        }


        public string cstm_sql1()
        {
            return cstm_sqlqry1;
        }
        public string cstm_sql2()
        {
            return cstm_sqlqry2;
        }
        public string cstm_sql3()
        {
            return cstm_sqlqry3;
        }


    }
}
