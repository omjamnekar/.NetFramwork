using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tempreture
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(TextBox1.Text);
            double f = (temp * 9 / 5) + 32;
            Label1.Text = f.ToString().Substring(0,4);
        }
    }
}