using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientWebApplication
{
    public partial class SearchWebForm : System.Web.UI.Page
    {
        ProductServiceReference2.ProductWebService2SoapClient obj = new ProductServiceReference2.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gridViewSearch.DataSource = obj.SearchProduct(txtProductId.Text);
            gridViewSearch.DataBind();
        }

        protected void prevbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./ClientPanelWebForm.aspx");
        }
    }
}