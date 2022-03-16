using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Management_System
{
    public partial class user_login : System.Web.UI.Page
    {
        String con = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void blogin_Click(object sender, EventArgs e)
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
                String id = null , name = null , balance = null , acc = null ;
                String encryptedPass = Encrypt(txtpass.Text.Trim());
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select account_number,name , balance , account_number" +
                        "  from dbo.user_table where account_number=@acc and password=@pass";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@acc", username.Text);
                    oCmd.Parameters.AddWithValue("@pass", encryptedPass);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            id = oReader["account_number"].ToString();
                            name = oReader["name"].ToString();
                            balance = oReader["balance"].ToString();
                            acc = oReader["account_number"].ToString();
                        }

                        myConnection.Close();
                    }
                }

                if (id != null)
                {
                    errormsg.Visible = false;
                    Response.Write("<script>alert('<p>Succesfull login</p>')</script>");
                    successmsg.Text = "<p>Succesfull login</p>";
                    string current_user = username.Text;

                    Session["logged_user"] = current_user;
                    Session["name"] = name;
                    Session["acc"] = acc;
                    Session["balance"] = balance;
                    Response.Redirect("/user-dash.aspx", false);

                }
                else
                {

                    errormsg.Text = "<p></br></br>Username or password Incorrect</p>";
                    /*Response.Write("<script>alert('Username or password Incorrect')</script>");*/
                    errormsg.Visible = true;
                }
            }
        }

        string Encrypt(String str)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
            string enc = Convert.ToBase64String(b);
            return enc;

        }
    }
}