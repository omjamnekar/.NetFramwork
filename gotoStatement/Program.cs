using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

        l1: Console.WriteLine("Enter two number :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c=a+b;
            Console.WriteLine("ans is" + c);
            goto l1 ;

        }
    }
}
