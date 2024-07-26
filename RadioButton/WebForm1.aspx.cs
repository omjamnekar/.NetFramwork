using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String age = " ";
            if(RadioButton1.Checked==true)
            {
                age =age+" "+RadioButton1.Text;
            }
            if (RadioButton2.Checked == true)
            {
                age = age+" "+RadioButton2.Text;

            }
            if (RadioButton3.Checked == true)
            {
                age = age + " " + RadioButton3.Text;
            }
            if (RadioButton4.Checked == true)
            {
                age = age + " " + RadioButton4.Text;
            }
            if (RadioButton5.Checked == true)
            {
                age = age + " " + RadioButton5.Text;
            }
            if (RadioButton6.Checked == true)
            {
                age = age + " " + RadioButton6.Text;
            }
            Label1.Text = "Age and Favorate Hobbies Are:" + " " + age;
        }
    }
}