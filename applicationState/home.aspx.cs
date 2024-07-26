using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace applicationState
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["name"] = TextBox1.Text;
            TextBox1.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Application["name"].ToString();    
        }
    }
}