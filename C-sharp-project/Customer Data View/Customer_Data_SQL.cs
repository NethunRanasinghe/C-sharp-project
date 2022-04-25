using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_project
{
    internal class Customer_Data_SQL
    {
        private int cnic=0;
        private string cfn="";
        private string cln = "";
        private int cphn = 0;
        private string cprv = "";
        private string cstdatasqlnic="";
        private string cstdatasqlname = "";
        private string cstdatasqlphno = "";
        private string cstdatasqlprv = "";

        public void set_cnic(int xnic)
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

        public void set_cstdatasqlnic()
        {
            cstdatasqlnic = "SELECT * FROM customer_registration WHERE nic='" + cnic + "'";
        }
        public void set_cstdatasqlname()
        {
            cstdatasqlname = "SELECT * FROM customer_registration WHERE first_name='" + cfn + "',lastname='"+cln+"'";
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
