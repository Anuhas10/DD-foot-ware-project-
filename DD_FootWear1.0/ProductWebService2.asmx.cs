using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace DD_FootWear1._0
{
    /// <summary>
    /// Summary description for ProductWebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductWebService2 : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;

        public SqlConnection getConnection()
        {
            try
            {
                sqlCon = new SqlConnection("data source=ANUHAS\\SQLEXPRESS; database=DD_FootWear; user id=admin; password=admin");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to Connecting Database!!!" + ex);
            }
            return sqlCon;
        }

        [WebMethod]
        public string AddProduct(string ProductId, string ProductName, string CateName, int QTY,int Price)
        {
            int NoRows = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO ProductTb VALUES ('" + ProductId + "','" + ProductName + "','" + CateName + "'," + QTY + "," + Price + ");", sqlCon);
                NoRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                return ex.ToString();
            }
            return NoRows.ToString();
        }


        [WebMethod]
        public string autoProductId()
        {
            string ProductId = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select productId from ProductTb", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                Boolean records = dr.HasRows;//F

                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();//P001
                    }
                    string idString = id.Substring(1);//001
                    int CTR = Int32.Parse(idString);//3

                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;//1+1=2
                        ProductId = "P00" + CTR;//P002
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        ProductId = "P0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        ProductId = "P" + CTR;
                    }
                }
                else
                {
                    ProductId = "P001";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                ProductId = ex.ToString();
            }
            return ProductId;
        }


        [WebMethod]
        public string AddCategory(string CategoryId, string CategoryName)
        {
            int NoRows = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTb VALUES('" + CategoryId + "','" + CategoryName + "');", sqlCon);
                NoRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return NoRows.ToString();
        }


        [WebMethod]
        public string autoCategoryId()
        {
            string CategoryId = null;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select categoryId from CategoryTb", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                Boolean records = dr.HasRows;//F

                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();//P001
                    }
                    string idString = id.Substring(1);//001
                    int CTR = Int32.Parse(idString);//3

                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;//1+1=2
                        CategoryId = "C00" + CTR;//P002
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        CategoryId = "C0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        CategoryId = "C" + CTR;
                    }
                }
                else
                {
                    CategoryId = "C001";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                CategoryId = ex.ToString();
            }
            return CategoryId;
        }

        [WebMethod]
        public DataSet getCategoryName()
        {
            DataSet ds = new DataSet();

            try
            {
                getConnection();
                SqlCommand cmdCate = new SqlCommand("SELECT categoryName FROM CategoryTb", sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmdCate);
                da.Fill(ds, "CategoryTb");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Category Name!" + ex);
            }
            return ds;
        }

        [WebMethod]
        public string getCategoryId(string CategoryName)
        {
            string CategoryId = "";

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("SELECT categoryId FROM CategoryTb WHERE categoryName = '" + CategoryName + "' ", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                Boolean records = dr.HasRows;
                
                if (records)
                {
                    while (dr.Read())
                    {
                        CategoryId = dr[0].ToString();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Searching Produt Category Name!!!" + ex);
            }
            return CategoryId;
        }


        [WebMethod]
        public DataSet SearchProduct(string ProductName)
        {
            DataSet ds = new DataSet();

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb WHERE productName = '" + ProductName + "' ", sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "ProductTb");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Searching Product!!!" + ex);
            }
            return ds;
        }

        [WebMethod]
        public DataSet getAllProduct()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "ProductTb");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error something going wrong!!!" + ex);
            }
            return ds;
        }

        [WebMethod]
        public string UpdateProductName(string ProductId, string ProductnewName)
        {
            int NoRows = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTb SET productName = @NewName WHERE productId = @ProductId", sqlCon);
                cmd.Parameters.AddWithValue("@NewName", ProductnewName);
                cmd.Parameters.AddWithValue("@ProductId", ProductId);
                NoRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return NoRows.ToString();
        }

        [WebMethod]
        public string PlaceOrder(string OrderId, string ProductId, int OrderQty)
        {
            int NoRecords = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO OrdersTb VALUES('" + OrderId + "','" + ProductId + "', " + OrderQty + ");", sqlCon);
                NoRecords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to Adding Orders!!!" + ex);
            }
            return NoRecords.ToString();
        }

        [WebMethod]
        public string autoOrderId()
        {
            string OrderId = null;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("SELECT OrderId FROM OrdersTb", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                Boolean records = dr.HasRows;//F

                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();//R001
                    }
                    string idString = id.Substring(1);//001
                    int CTR = Int32.Parse(idString);//3

                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;//1+1=2
                        OrderId = "R00" + CTR;//R002
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        OrderId = "R0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        OrderId = "R" + CTR;
                    }
                }
                else
                {
                    OrderId = "R001";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                OrderId = ex.ToString();
            }
            return OrderId;
        }


        [WebMethod]
        public bool AddStock(string ProductId, int NewStock)
        {
            bool records = false;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTb SET qty = qty + " + NewStock + " WHERE productId = '" + ProductId + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                records = dr.HasRows;
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating stock: " + ex);
            }
            return records;
        }


        [WebMethod]
        public string DeleteCategory(string CategoryId)
        {
            int NoRec = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM CategoryTb WHERE categoryId='" + CategoryId + "'", sqlCon);
                NoRec = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to delete CATEGORY!!" + ex);
            }
            return NoRec.ToString();
        }


        [WebMethod]
        public string DeleteProduct(string ProductName)
        {
            int noRec = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM ProductTb WHERE productName='" + ProductName + "'", sqlCon);
                noRec = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to delete Product!!!" + ex);
            }
            return noRec.ToString();
        }
    }
}
