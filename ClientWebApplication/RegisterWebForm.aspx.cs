using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientWebApplication
{
    public partial class RegisterWebForm : System.Web.UI.Page
    {
        UserServiceReference2.WebService1SoapClient obj = new UserServiceReference2.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUserId.Text = obj.autoUserId();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string value = obj.RegisterUsers(txtUserId.Text, txtUserName.Text, txtPassword.Text, dlUserType.SelectedValue);

            int noRecord = Int32.Parse(value);

            if (noRecord > 0)
            {
                lblText.Text = "Your Registration Successfully...";

            }
            else
            {
                lblText.Text = "FAIL to Add Data!";
            }
        }

        protected void btnPrev_Click(object sender, EventArgs e)
        {
            Response.Redirect("./LoginWebForm.aspx");
        }
    }
}