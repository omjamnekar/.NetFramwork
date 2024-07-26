using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d,e ,result ,perce;
            Console.WriteLine("Enter marks of five subjects: ");
            a= Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            result = a+b+c+d+e;
            perce = (result * 100) / 500;

            if (perce >= 75)
            {
                Console.WriteLine("you got O grade bro");

            }else if (perce >= 65 && perce <= 75)
            {

                Console.WriteLine("you got A grade bro");
            }
            else if (perce >=55 && perce <= 65)
            {
                Console.WriteLine("You got B grade");
            }
            else if (perce >= 45 && perce <= 65)
            {

                Console.WriteLine("you got C grade");
            }
            else if (perce >= 35 && perce <= 45)
            {

                Console.WriteLine("you got D grade");
            }

            else
            {
                Console.WriteLine("Better luck next bro!");
            }
            Console.ReadKey();
        }

    }
}
