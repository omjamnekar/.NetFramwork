using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateManage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            int count = int.Parse(HiddenField1.Value);
            count = count +1;
            Response.Write("count is "+ count);
            HiddenField1.Value = count.ToString();

        }
    }
}