using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminWebPannel
{
    public partial class Add_CategoryWebForm : System.Web.UI.Page
    {
        ProductServiceReference1.ProductWebService2SoapClient obj = new ProductServiceReference1.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCategoryId.Text = obj.autoCategoryId();
        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            string value = obj.AddCategory(txtCategoryId.Text, txtCategoryName.Text);

            int NoRecords = Int32.Parse(value);

            if (NoRecords > 0)
            {
                lblText.Text = "$ Category Successfully Inserted $";
            }
            else
            {
                lblText.Text = "Fail to Add Category!!!";
            }
        }

        protected void prevbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AdminDashboardWebForm.aspx");
        }
    }
}