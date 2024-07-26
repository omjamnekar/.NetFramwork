using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace classAndFunction
{
    public partial class home : System.Web.UI.Page
    {

        class addition
        {
            public int add(int a , int b) {
                return a + b;

            }
        }
            
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            addition ad= new addition();

            Label1.Text = ad.add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}