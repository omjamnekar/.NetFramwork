using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Color
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked==true)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            if (RadioButton2.Checked == true)
            {
                Label1.ForeColor = System.Drawing.Color.Blue;
            }
            if (RadioButton3.Checked == true)
            {
                Label1.ForeColor = System.Drawing.Color.Orange;
            }


            if(CheckBox1.Checked == true) {
                Label1.Font.Bold = true;
            }
            else
            {
                Label1.Font.Bold=false;
            }
            if (CheckBox2.Checked == true)
            {
                Label1.Font.Italic = true;
            }
            else
            {
                Label1.Font.Italic = false;
            }
            if (CheckBox3.Checked == true)
            {
                Label1.Font.Underline = true;
            }
            else
            {
                Label1.Font.Underline= false;
            }
            Label1.Text=TextBox1.Text;
        }
        
    }
}