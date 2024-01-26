using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientWebApplication
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        UserServiceReference2.WebService1SoapClient obj = new UserServiceReference2.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (obj.LoginUsers(txtUserId.Text, txtUserName.Text, txtPassword.Text))
            {
                Response.Redirect("./ClientPanelWebForm.aspx");
            }
            else
            {
                lblText.Text = "INVALID iNFORMATION try Again!!!!";
            }
        }

        protected void lbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("./RegisterWebForm.aspx");
        }
    }
}