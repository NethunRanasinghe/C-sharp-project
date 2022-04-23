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
    internal class DBConn
    {
        private readonly string connstringdbx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\C-sharp-project\C-sharp-project\Databases\DB1\systmDB.mdf;Integrated Security=True;Connect Timeout=30";

        public string getdbconn()
        {
            return connstringdbx;

        }


    }
}
