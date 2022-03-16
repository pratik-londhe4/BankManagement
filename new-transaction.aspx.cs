﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Management_System
{
    public partial class NewTransaction : System.Web.UI.Page
    {
        String con = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void send_money_Click(object sender, EventArgs e)
        {
            String user_bal = null;
            using (SqlConnection sqlconn = new SqlConnection(con))
            {
                SqlCommand check = new SqlCommand("select balance from dbo.user_table where account_number = @account", sqlconn);
                check.Parameters.AddWithValue("@account", Session["acc"]);
                sqlconn.Open();
                using (SqlDataReader oReader = check.ExecuteReader())
                {
                    while (oReader.Read())
                    {

                        user_bal = oReader["balance"].ToString();


                    }

                }
                double send_amount = Convert.ToDouble(amount.ToString());

                if(float.Parse(user_bal) < send_amount){
                    errmsg.Text = "<p>You have insufficient balance</p>";
                    return;
                }
                else
                {

                }
            }

        }
    }
}