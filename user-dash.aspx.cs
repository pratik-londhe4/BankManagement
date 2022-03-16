using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Management_System
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            name.Text = Session["name"].ToString();
            balance.Text = Session["balance"].ToString();
            accnum.Text = Session["acc"].ToString();

        }
    }
}