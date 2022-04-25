using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_project
{
    internal class Customer_Data_SQL
    {
        public string cnic="";
        public string cfn="";
        public string cln = "";
        public int cphn = 0;
        public string cprv = "";
        public string cstdatasqlnic="";
        public string cstdatasqlname = "";
        public string cstdatasqlphno = "";
        public string cstdatasqlprv = "";

        public void set_cnic(string xnic)
        {
            cnic = xnic;
        }
        public void set_cname(string xfn, string xln)
        {
            cfn = xfn;
            cln = xln;
        }
        public void set_cphno(int xphn)
        {
            cphn = xphn;
        }
        public void set_cprv(string xprvn)
        {
            cprv = xprvn;
        }
        public void set_cnm(string xfn,string xln)
        {
            cfn = xfn;
            cln=xln;
        }

        public void set_cstdatasqlnic()
        {
            cstdatasqlnic = "SELECT * FROM customer_registration WHERE nic='" + cnic + "'";
        }
        public void set_cstdatasqlname()
        {
            cstdatasqlname = "SELECT * FROM customer_registration WHERE first_name='" + cfn + "' OR last_name='"+cln+"'";
        }
        public void set_cstdatasqlphno()
        {
            cstdatasqlphno = "SELECT * FROM customer_registration WHERE phone_number='" + cphn + "'";
        }
        public void set_cstdatasqlcprv()
        {
            cstdatasqlprv = "SELECT * FROM customer_registration WHERE province='" + cprv + "'";
        }

        public string get_cstdatasqlnic()
        {
            return cstdatasqlnic;
        }
        public string get_cstdatasqlname()
        {
            return cstdatasqlname;
        }
        public string get_cstdatasqlphno()
        {
            return cstdatasqlphno;
        }
        public string get_cstdatasqlcprv()
        {
            return cstdatasqlprv;
        }


    }
}
