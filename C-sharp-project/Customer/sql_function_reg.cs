using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C_sharp_project
{
    internal class sql_function_reg:customer_reg_sql
    {
        public void function_sql_execute()
        {
            SqlConnection connection = new SqlConnection(getdbconn());
            SqlCommand cmd = new SqlCommand(get_rgsql(), connection);
            try
            {
                connection.Open();  
                cmd.ExecuteNonQuery();
                
            }
            catch (SqlException ecr)
            {
                Console.WriteLine(ecr.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
