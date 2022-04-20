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

namespace C_sharp_project.ProfitNlossClasses
{
    internal class DBConn
    {
        private string connstringdbx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sandman\source\repos\C-sharp-project\C-sharp-project\bin\Debug\net5.0-windows\systmDB.mdf;Integrated Security=True;Connect Timeout=30";
        public string getdbconn()
        {
            return connstringdbx;
        }
    }
}
