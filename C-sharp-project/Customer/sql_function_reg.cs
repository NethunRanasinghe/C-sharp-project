using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
                int res=cmd.ExecuteNonQuery();
                if(res!=0)
                {
                    MessageBox.Show("Record Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Record Insertion Failed");
                }
                
            }
            catch (MySqlException ecr)
            {
                MessageBox.Show(ecr.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
