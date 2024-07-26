using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static multipleInheritance.WebForm1;

namespace multipleInheritance
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        interface Circle
        {
             double circum(int r);
        }


        interface Rect
        {
            double rect( int l , int b);
        }


        public class CalculateCircle : Circle , Rect
        {
           public  double circum(int r) {
                return 2 * 3.14 * r;
            }
            

            public double rect(int l , int b)
            {
                return l * b;
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int l,b;
            l=Convert.ToInt32(TextBox1.Text);
            CalculateCircle calculateCircle = new CalculateCircle();
            Label1.Text  ="Area of circle is :" + calculateCircle.circum(l).ToString();
        
        }
        
      


        protected void Button2_Click(object sender, EventArgs e)
    {

            CalculateCircle calculateCircle = new CalculateCircle();

            
            string  ct= calculateCircle.rect(Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text)).ToString();
            Label2.Text = "Area of rectangle is :" +ct;

        }
}
}