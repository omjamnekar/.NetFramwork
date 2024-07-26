using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Demo
    {
        public double a,b,c,d,e,total,parc;
        public void input()
        {
            Console.WriteLine("Enter marks of student: ");
            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());

        }

    }

    public class Area : Demo
    {
        public void area_cal()
        {
            total = a+b+d+c+e;
            Console.WriteLine("Total marks optain by student is " + total);
        }

    }

    public class Circum : Area
    {
        public void circum_cal()
        {
            parc = (total *100) /500;
            Console.WriteLine("Percentage of student is: " + parc+"%");
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
