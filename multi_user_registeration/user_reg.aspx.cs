using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace multi_user_registeration
{
    public partial class user_reg : System.Web.UI.Page
    {
        conClass1 obj = new conClass1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string select = "select max(user_id) from login_table";
            string userid = obj.fn_exescalar(select);

            int user_id = 0;
            if (userid == "")
            {
                user_id = 1;
            }
            else
            {

                int newuserid = Convert.ToInt32(userid);
                user_id = newuserid + 1;
            }
            string insrtusr = "insert into user_reg_table values (" + user_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj.fn_exenonqury(insrtusr);
            if (i == 1)
            {
                string instlog = "insert into login_table values (" + user_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','user','active')";
                int b = obj.fn_exenonqury(instlog);
            }
        }
    }
}