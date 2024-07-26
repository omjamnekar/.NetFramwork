using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownLIst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String str = " ";
            for(int i = 0;i<DropDownList1.Items.Count;i++)
            {
                if (DropDownList1.Items[i].Selected==true)
                {
                    str = DropDownList1.Items[i].Text;
                }
            }
            Label1.Text= "City Selected=" + str;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}