using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            c = a - b;
            Label1.Text = "Substraction = " + c;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a= Convert.ToInt32(TextBox1.Text);
            b= Convert.ToInt32(TextBox2.Text);
            c = a + b;
            Label1.Text = "Addition = " + c;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            c = a * b;
            Label1.Text = "Multiplication= " + c;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            c = a / b;
            Label1.Text = "Division = " + c;
        }
    }
}