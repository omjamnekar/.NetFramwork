using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookieOrigin
{
    public partial class CookiesWelcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String name, city, age;
            name = Request.Cookies["name"].Value;
            age = Request.Cookies["age"].Value;
            city = Request.Cookies["city"].Value;

            Response.Write("Name is="+name+" "+"City is="+city+" "+"Age is="+age);
        }
    }
}