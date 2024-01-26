using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminWebPannel
{
    public partial class AdminDashboardWebForm : System.Web.UI.Page
    {
        ProductServiceReference1.ProductWebService2SoapClient obj = new ProductServiceReference1.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("./RegisterWebForm.aspx");
        }

        protected void lbtnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AddProductWebForm.aspx");
        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Add_CategoryWebForm.aspx");
        }

        protected void btnSearchProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("./SearchProductWebForm.aspx");
        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {
            gvView.DataSource = obj.getAllProduct();
            gvView.DataBind();
        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("./UpdateProductWebForm.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("./DeleteItemsWebForm.aspx");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("./OrderProductWebForm.aspx");
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AddProductWebForm.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("./LoginWebForm.aspx");
        }

        protected void btnAddStock_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AddStockWebForm.aspx");
        }
    }
}