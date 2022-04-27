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
    internal class DBConn
    {
        private readonly string connstringdbxmpp = "server=localhost; user id=root; database=systDB";
        private readonly string connstringdbxdcean = "datasource=rsmt-management-system-do-user-11431826-0.b.db.ondigitalocean.com; " +
                                    "port=25060; " +
                                    "username=doadmin; " +
                                    "password=AVNS_xJ37XvPtSUi3vzk; " +
                                    "database=systDB;";

        public string getdbconnxmpp()
        {
            return connstringdbxmpp;

        }
        public string getdbconndcean()
        {
            return connstringdbxdcean;

        }


    }
}
