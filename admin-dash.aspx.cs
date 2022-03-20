using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Management_System
{
    public partial class admin_dash : System.Web.UI.Page
    {
        String con = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            var httpCookie = Request.Cookies["panelIdCookie"];
            if (httpCookie == null)

                Response.Redirect("admin-login.aspx");

            else
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "select count(account_type) as saving from user_table where account_type = 2";
                    string oString2 = "select count(account_type) as cac from user_table where account_type = 1";
                    string oString3 = "select count(account_type) as total from user_table";

                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    SqlCommand oCmd2 = new SqlCommand(oString2, myConnection);
                    SqlCommand oCmd3 = new SqlCommand(oString3, myConnection);


                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            saac.Text = oReader["saving"].ToString();
                        }

                        
                    }
                    using (SqlDataReader oReader = oCmd2.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            cuac.Text = oReader["cac"].ToString();
                        }


                    }
                    using (SqlDataReader oReader = oCmd3.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            toac.Text = oReader["total"].ToString();
                        }


                    }
                }

            }
        }




        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Cookies.Remove("panelIdCookie");
            }

    }
    }
