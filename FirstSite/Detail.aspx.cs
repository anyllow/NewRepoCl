using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstSite
{
    public partial class Default1 : System.Web.UI.Page
    {
        Dictionary<int, string> _data = new Dictionary<int, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            _data.Add(1, "C# - Лучший язык №1");
            _data.Add(2, "Java - Лучший язык №2");

            string temp = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(temp))
            {
                int id = Convert.ToInt32(temp);
                Label1.Text = _data[id];
            }
            else
            {
                Label1.Text = "Empty";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}