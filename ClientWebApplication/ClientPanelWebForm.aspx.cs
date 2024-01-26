using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientWebApplication
{
    public partial class ClientPanelWebForm : System.Web.UI.Page
    {
        ProductServiceReference2.ProductWebService2SoapClient obj = new ProductServiceReference2.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = obj.autoOrderId();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./SearchWebForm.aspx");
        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {
            gvProduct.DataSource = obj.getAllProduct();
            gvProduct.DataBind();
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string OrderId = txtOrderId.Text;
            string ProductId = txtProductId.Text;
            int qty = Convert.ToInt32(txtOrderQty.Text);

            string orderPlace = obj.PlaceOrder(OrderId, ProductId, qty);
            lblText.Text = "Order Placed Successfully.";
        }
    }
}