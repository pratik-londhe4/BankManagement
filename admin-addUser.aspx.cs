using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Management_System
{
    public partial class admin_addUseraspx : System.Web.UI.Page
    {
        String con = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        String cEmail = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_user_Click(object sender, EventArgs e)
        {
            string EncryptedPass = Encrypt(txtPassword.Text.Trim());
            


            using (SqlConnection sqlconn = new SqlConnection(con))
            {
                SqlCommand check = new SqlCommand("select aadhar_card from dbo.user_table where aadhar_card = @aadhar", sqlconn);
                check.Parameters.AddWithValue("@aadhar", addnum.Text.Trim());
                sqlconn.Open();
                using (SqlDataReader oReader = check.ExecuteReader())
                {
                    while (oReader.Read())
                    {

                        cEmail = oReader["aadhar_card"].ToString();


                    }

                }

                if (cEmail == addnum.Text.Trim())
                {
                    errormsg.Text = "<p>User Already Registered";
                    return;
                }
                else
                {






                    SqlCommand add = new SqlCommand("add_user", sqlconn);
                    add.CommandType = CommandType.StoredProcedure;
                    add.Parameters.AddWithValue("@id", Convert.ToInt32(hfuserid.Value == "" ? "0" : hfuserid.Value));
                    add.Parameters.AddWithValue("@name", name.Text.Trim());
                    add.Parameters.AddWithValue("@aadhar_card", addnum.Text.Trim());
                    add.Parameters.AddWithValue("@balance", balance.Text.Trim());
                    add.Parameters.AddWithValue("@account_type",  actype.SelectedValue);
                    add.Parameters.AddWithValue("@password", EncryptedPass);
                    add.Parameters.AddWithValue("@address", address.Text);
                   



                    add.ExecuteNonQuery();
                   // clr();
                   // errormsg.Visible = true;
//errormsg.Text = "Success";

                }


            }
        }

      //  void clr()
      //  {
      //      fname.Text = lname.Text = email.Text = mobile.Text = dob.Text = addr.Text
       //         = city.Text = pin.Text = pass.Text = hfuserid.Value = cpass.Text = "";
      //  }

        string Encrypt(String str)
        {
            byte[] b = System.Text.Encoding.ASCII.GetBytes(str);
            string enc = Convert.ToBase64String(b);
            return enc;

        }
    }
}



        