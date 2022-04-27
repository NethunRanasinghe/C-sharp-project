using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_project
{
    internal class Select_DBConn
    {
        public string GetDBConn()
        {
            DBConn dBConn = new DBConn();
            string getdb="";
            if (Choose_Database.DBType == "xampp")
            {
                getdb = dBConn.getdbconnxmpp();
            }
            else if(Choose_Database.DBType =="dcean")
            {
                getdb=dBConn.getdbconndcean();
            }
            else
            {
                getdb = dBConn.getdbconnxmpp();
            }
            return getdb;
        }
    }
}
