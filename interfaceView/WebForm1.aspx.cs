using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaceView
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

        public class CalculateCircle : Circle
        {
            public double circum(int r)
            {
                return 2*3.14 *r;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CalculateCircle c = new CalculateCircle();
            int value = Convert.ToInt32(TextBox1.Text); 

           Label1.Text =  c.circum(value).ToString();


        }
    }
}