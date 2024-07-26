using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
        public class Demo
    {
        public double area, r;
        public void input()
        {
            Console.WriteLine("Enter value of radius: ");
            r= Convert.ToInt32(Console.ReadLine());

        }

    }
    
       public class Area :Demo
    {
        public void area_cal()
        {
           area = 2 * 3.14 * r;
            Console.WriteLine("Area of circle is : "+area);
        }

    }

    public class Circum:Area
    {
        public void circum_cal()
        {
            area = 2 * 3.14 * r*r;
            Console.WriteLine("Area of circle is : "+ area);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Circum circum = new Circum();
            circum.input();

            circum.area_cal();
            circum.circum_cal();

            Console.ReadKey();
        }
    }
}
