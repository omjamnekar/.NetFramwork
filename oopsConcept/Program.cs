using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcept
{

    public class Area
    {
        double area;
         public void area_cal(int b)
        {
            area = 3.14 * b * b;
            Console.WriteLine("Area of Circle is: " + area);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Area area = new Area(); 
            area.area_cal(10);
            Console.ReadKey();
        }

    }
}
