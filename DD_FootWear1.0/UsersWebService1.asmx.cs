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
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection sqlConn = null;

        public SqlConnection getConnection()
        {
            try
            {
                sqlConn = new SqlConnection("data source=ANUHAS\\SQLEXPRESS; database=DD_FootWear; user id=admin; password=admin");
                sqlConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to Connecting Database!!!" + ex);
            }
            return sqlConn;
        }

        [WebMethod]
        public bool LoginUsers(string userId, string username, string password)
        {
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM userTb WHERE userid='" + userId + "' AND username='" + username + "' AND password='" + password + "'", sqlConn);
                SqlDataReader dR = cmd.ExecuteReader();
                Boolean result = dR.HasRows;

                if (result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [WebMethod]
        public string RegisterUsers(string userid, string username, string password, string usertype)
        {
            int NoRecord = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into userTb values('" + userid + "','" + username + "','" + password + "','" + usertype + "');", sqlConn);
                NoRecord = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return NoRecord.ToString();
        }

        [WebMethod]
        public string autoUserId()
        {
            string UserId = null;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("SELECT userid FROM userTb", sqlConn);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                Boolean records = dr.HasRows;

                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();//U001
                    }
                    string idString = id.Substring(1);//001
                    int CTR = Int32.Parse(idString);//1

                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;//1+1=2
                        UserId = "U00" + CTR;//U002
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        UserId = "U0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        UserId = "U" + CTR;
                    }
                }
                else
                {
                    UserId = "U001";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                UserId = ex.ToString();
            }
            return UserId;
        }


        
    }
}
