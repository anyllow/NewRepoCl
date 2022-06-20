using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieMethod
{
    public partial class ReadCooke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["mCookie"];

            if (cookie != null)
            {
                Label1.Text = cookie.Value;
            }
        }
    }
}