using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminWebPannel
{
    public partial class AddStockWebForm : System.Web.UI.Page
    {
        ProductServiceReference1.ProductWebService2SoapClient obj = new ProductServiceReference1.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddStock_Click(object sender, EventArgs e)
        {
            string ProductId = txtProductId.Text;
            int newStock = Convert.ToInt32(txtNewStock.Text);

            bool result = obj.AddStock(ProductId, newStock);

            if (result)
            {
                lblText.Text = "Stock Added Successfully.";
            }
        }

        protected void prevbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AdminDashboardWebForm.aspx");
        }
    }
}