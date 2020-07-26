using System;
using Ns_SQL;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AdhamProfile.Pages
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCreatelogin_Click(object sender, EventArgs e)
        {

            SQL_User_Object.SQL_User_DA_Access objUserDA = new SQL_User_Object.SQL_User_DA_Access();
            SQL_User_Object objUser = new SQL_User_Object();

            objUser.FULLNAME = txtFullName.Text.Trim();
            objUser.EMAIL = txtEmail.Text.Trim();
            objUser.PASSWORD = txtPassword.Text;
            objUser.STATUS = "Active";

            if (objUserDA.InsertUser(objUser))
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}