using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slipSalary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public double calculation(double salary)
        {
            double DA = 80 / 100;
            double HRA = 20 / 100;
            double MEDICAL = 10 / 100;
                
            return salary + DA + HRA + MEDICAL;
        }


        public class NetPlayeer
        {
            public double calculation_net(double gross , string deduc)
            {
                double PF = 12 / 100, decvalue;
                if (deduc == "LIC")
                {
                    decvalue = 10 / 100;
                }
                else if (deduc == "SBI")
                {
                    decvalue = 30 / 100;
                }
                else if (deduc == "Medi Claim")
                {
                    decvalue = 40 / 100;
                }
                else
                {
                    decvalue =5/ 100;    
                }

                return gross  - (PF +decvalue);
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            double net, gross;
            double salary = Convert.ToInt32(TextBox1.Text);
            string name  = TextBox1.Text;
            string salary = TextBox2.Text;

            string  designation = Tex

        }
    }
}