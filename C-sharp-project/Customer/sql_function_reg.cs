using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace C_sharp_project
{
    internal class sql_function_reg:customer_reg_sql
    {
        public void function_sql_execute()
        {
            MySqlConnection connection = new MySqlConnection(getdbconn());
            MySqlCommand cmd = new MySqlCommand(get_rgsql(), connection);
            try
            {
                connection.Open();  
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ecr)
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
