using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownLIst_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text="Count="+DropDownList1.Items.Count.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.Text.ToString();

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue.ToString();

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = " Index="+DropDownList1.SelectedIndex;

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Remove("Mumbai");
            Label1.Text = "Removed";

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Hydrabad");
            Label1.Text = " Item Added";

        }
    }
}