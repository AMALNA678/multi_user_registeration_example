using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace multi_user_registeration
{
    public class conClass1
    {
        SqlConnection con;
        SqlCommand cmd;

        public conClass1()
        {
            con = new SqlConnection(@"server=LAPTOP-5IOKI1U0\SQLEXPRESS;database=multiuser_db;integrated security=true");
        }
        public int fn_exenonqury(string qury)
        {
            cmd = new SqlCommand(qury, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string fn_exescalar(string qury)
        {
            cmd = new SqlCommand(qury, con);
            con.Open();
            string v = cmd.ExecuteScalar().ToString();
            con.Close();
            return v;
        }

    }
    
}