using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace delegates_multi_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        delegate void mdelegate();
        class dm
        {
            public void display()
            {
                Console.WriteLine("Hellooo ");
                
            }

            public void print() {
                Console.WriteLine("Invoke");
            }



        }

        class Program
        {
            static void Main(string[] args)
            {
                 dm d = new dm();
                mdelegate m1 = new mdelegate(d.display);

                mdelegate m2= new mdelegate(d.print);


                mdelegate m3 = m1 + m2;

                mdelegate m4 = m2 + m1;

                mdelegate m5 = m3 - m2;

                m1();
                m2();
                m3();
                    
                m4();
                m5();
                Console.ReadKey();  
            }
        }
    }
}