using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminWebPannel
{
    public partial class DeleteItemsWebForm : System.Web.UI.Page
    {
        ProductServiceReference1.ProductWebService2SoapClient obj = new ProductServiceReference1.ProductWebService2SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string NoRecords = obj.DeleteCategory(txtCategoryId.Text);
            int rec = Int32.Parse(NoRecords);
            
            if (rec > 0)
            {
                lblText.Text = "Category Delete Successfully.";
            }
        }

        protected void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string noRecord = obj.DeleteProduct(txtProductName.Text);
            int noRec = Int32.Parse(noRecord);

            if (noRec > 0)
            {
                lblText1.Text = "Product Delete Successfully.";
            }
        }

        protected void btnDash_Click(object sender, EventArgs e)
        {
            Response.Redirect("./AdminDashboardWebForm.aspx");
        }
    }
}