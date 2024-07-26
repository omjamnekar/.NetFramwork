using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sessionRedir
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nm, city;
            nm = Session["name"].ToString();
            city = Session["city"].ToString();
            Response.Write("name is"+ nm +" city is " + city);
        }
    }
}