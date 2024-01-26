using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminWebPannel
{
    public partial class OrderProductWebForm : System.Web.UI.Page
    {
        ProductServiceReference1.ProductWebService2SoapClient obj = new ProductServiceReference1.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = obj.autoOrderId();
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string OrderId = txtOrderId.Text;
            string ProductId = txtOrderProductId.Text;
            int qty = Convert.ToInt32(txtOrderQuantity.Text);

            string Order = obj.PlaceOrder(OrderId, ProductId, qty);
            lblText.Text = "Order Placed Successfull...";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AdminDashboardWebForm.aspx");
        }
    }
}