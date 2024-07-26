using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{


    public class Demo
    {
        double area;
        public void calc(int r)
        {   
            area = 2*3.14*r*r;
            Console.WriteLine("circumference of circle is :"+area);
        }
        
        public void calc(int l,int b)
        {
            area = l*b ;
            Console.WriteLine("Area of rectangle is :" + area);

        }
    }


    internal class Program
    {

       
        static void Main(string[] args)
        {
            Demo demo = new Demo();
        
            Console.WriteLine("Enter a radius: ");
            demo.calc(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter length and breath: ");
            demo.calc(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));


            Console.ReadKey();
        }
    }
}
