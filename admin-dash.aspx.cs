using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Management_System
{
    public partial class admin_dash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var httpCookie = Request.Cookies["panelIdCookie"];
            if (httpCookie == null)

                Response.Redirect("admin-login.aspx");
            }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Cookies.Remove("panelIdCookie");
            }
    }
    }
