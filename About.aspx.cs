using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            bool IsAuthenticated = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            if (!Request.IsAuthenticated)
            {
               // Response.Redirect("Login.aspx");
            }
        }
    }
}