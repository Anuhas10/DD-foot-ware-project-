using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AdminWebPannel
{
    public partial class AddProductWebForm : System.Web.UI.Page
    {
        ProductServiceReference1.ProductWebService2SoapClient obj = new ProductServiceReference1.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = obj.getCategoryName();
                dlCategoryName.DataSource = ds;
                dlCategoryName.DataBind();
                dlCategoryName.DataValueField = "categoryName";
                dlCategoryName.DataBind();
            }

            txtProductId.Text = obj.autoProductId();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CategoryId = obj.getCategoryId(dlCategoryName.Text);
            string NoRecords = obj.AddProduct(txtProductId.Text, txtProductName.Text, CategoryId, Convert.ToInt32(txtQty.Text), Convert.ToInt32(txtPrice.Text));
            int records = Int32.Parse(NoRecords);

            if (records >= 1)
            {
                lblText.Text = "Product Inseted Successfully.";
            }
            else
            {
                lblText.Text = "Fail to Add Product!!!";
            }
        }

        protected void previousbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AdminDashboardWebForm.aspx");
        }
    }
}