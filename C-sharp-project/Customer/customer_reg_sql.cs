﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_project
{
    internal class customer_reg_sql:DBConn
    {
        private int nc=0;
        private string fnm="";
        private string lnm = "";
        private string adl1 = "";
        private string adl2 = "";
        private int phn=0;
        private string eml = "";
        private string prvnce = "";
        private string sql_reg = "";

        public void set_regvr(int intc,string vrfn,string vrlnm,string vradl1, string vradl2, int vrphn, string vreml, string vrprvnce)
        {
            nc = intc;
            fnm = vrfn;
            lnm = vrlnm;  
            adl1 = vradl1;
            adl2 = vradl2;
            phn = vrphn;
            eml = vreml;
            prvnce = vrprvnce;
        }

        public void set_rgsql()
        {
            sql_reg = "INSERT INTO customer_registration(nic,first_name,last_name,address,phone_number,email,province) VALUES('" + nc + "','" + fnm + "','" + lnm + "','" + adl1 + "','" + phn + "','" + eml + "','" + prvnce + "')";
        }
        public string get_rgsql() 
        {
            return sql_reg;
        }
    }
}
