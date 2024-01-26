using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminWebPannel
{

    public partial class LoginWebForm : System.Web.UI.Page
    {
        UserServiceReference.WebService1SoapClient obj = new UserServiceReference.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (obj.LoginUsers(txtUserId.Text, txtUserName.Text, txtPassword.Text))
            {
                Response.Redirect("./AdminDashboardWebForm.aspx");
            }
            else
            {
                lblText.Text = "Your UserId, Username or password is WRONG!";
            }
        }

        protected void lbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("./RegisterWebForm.aspx");
        }
    }
}