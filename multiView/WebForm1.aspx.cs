using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace multiView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;


        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            MultiView1.ActiveViewIndex = 1;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string name, city, address;
            string age, number;

            name = Convert.ToString(TextBox1.Text);
            city = Convert.ToString(TextBox2.Text);
            address = Convert.ToString(TextBox3.Text);
            age = Convert.ToString(TextBox4.Text);

            number = Convert.ToString(TextBox5.Text);

            Label1.Text = "user\n name:" + name + "<br>city: " + city + "<br>address: " + address + "<br>age: " + age + "<br>number: " + number;

            MultiView1.ActiveViewIndex = 2;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {

            MultiView1.ActiveViewIndex = 1;
           }


    }
}