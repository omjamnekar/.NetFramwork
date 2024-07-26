using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deligates
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public delegate int calculate(int a, int b);

        public class demoDelegate
        {
            public int sum(int a , int b)
            {
                return a + b;

            }


            public int sub(int a ,int b)
            {
                return a - b;   
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, res, res2;
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);

            demoDelegate d = new  demoDelegate();

            calculate c1 = new calculate(d.sum);
            calculate c2 = new calculate(d.sub);

            res = c1(a,b);

            res2 = c2(a, b);

            Label1.Text = "The addition is is: " + res.ToString() + "<br>" + "the substract is "+ res2.ToString();    
        }
    }
}