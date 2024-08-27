using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace multi_user_registeration
{
    public partial class login : System.Web.UI.Page
    {
        conClass1 obj = new conClass1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {;
            string logtab = "select count(user_id) from login_table where username = '" + TextBox1.Text + "'and password = '" + TextBox2.Text + "'";
            string cuntid = obj.fn_exescalar(logtab);
            int cuntid1 = Convert.ToInt32(cuntid);
            if(cuntid1==1)
            {
                string v = "select user_id from login_table where username = '" + TextBox1.Text + "'and password = '" + TextBox2.Text + "'";
                string userid = obj.fn_exescalar(v);
                Session["userid"] = userid;
                string v2 = "select log_type from login_table where username = '" + TextBox1.Text + "'and password = '" + TextBox2.Text + "'";
                string logtyp = obj.fn_exescalar(v2);
                if(logtyp== "admin")
                {
                    Label1.Text = "Admin";
                }
                else if (logtyp == "user")
                {
                    Label1.Text = "User";
                }
                else
                {
                    Label1.Text = "invalid username and password";
                }
            }



        }
    }
}