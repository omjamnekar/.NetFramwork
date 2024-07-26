using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String St = " ";
            for (int i = 0; i<CheckBoxList1.Items.Count;i++)
            {
                if (CheckBoxList1.Items[i].Selected==true)
                {
                    St += " " + CheckBoxList1.Items[i].Text;
                }
            }
            Label1.Text = "Selected Languages are=" + St;
        }
    }
}