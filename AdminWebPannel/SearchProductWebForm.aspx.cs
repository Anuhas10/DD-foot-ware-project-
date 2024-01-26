using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminWebPannel
{
    public partial class SearchProductWebForm : System.Web.UI.Page
    {
        ProductServiceReference1.ProductWebService2SoapClient obj = new ProductServiceReference1.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gvProduct.DataSource = obj.SearchProduct(txtproductId.Text);
            gvProduct.DataBind();
        }

        protected void prevbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AdminDashboardWebForm.aspx");
        }
    }
}