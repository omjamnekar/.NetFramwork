using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace countViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count;
            
            count = Convert.ToInt32(ViewState["count1"] ) +1;
            ViewState["count1"] = count;
            
            Response.Write("count is = "+count);



        }
    }
}