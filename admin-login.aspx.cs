using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Management_System
{
    public partial class admin_login : System.Web.UI.Page
    {
        String con = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {

            if (username.Text == "")
            {
                errormsg.Text = "<p>Please Enter Email";
            }
            else if (txtpass.Text == "")
            {
                errormsg.Text = "<p>Please Enter Password";
            }
            else
            {
                String id = null;
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select Id  from dbo.admin where email=@email and password=@pass";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@email", username.Text);
                    oCmd.Parameters.AddWithValue("@pass", txtpass.Text.Trim());
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            id = oReader["Id"].ToString();
                        }

                        myConnection.Close();
                    }
                }

                if (id != null)
                {
                    errormsg.Visible = false;

                    string current_user = username.Text;
                    Session["logged_user"] = current_user;

                    Response.Redirect("admin-dash.aspx");

                }
                else
                {

                    errormsg.Text = "<p></br></br>Username or password Incorrect</p>";

                    errormsg.Visible = true;
                }
            }
        }


    }
}