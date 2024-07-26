using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoPostBAck
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text= TextBox1.Text;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = DropDownList1.Text.ToString();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label3.Text=ListBox1.Text.ToString();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label4.Font.Bold=true;
            
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            Label4.Font.Underline = true;
           
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

            
            Label4.Font.Italic = true;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Label4.ForeColor = System.Drawing.Color.Red;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Label4.ForeColor = System.Drawing.Color.Blue;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}