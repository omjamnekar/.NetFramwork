using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string longOne = "Hello World boy";
            string shortOne = "welcome";

            Console.WriteLine("Lowercase ="+longOne.ToLower());

            Console.WriteLine("Uppercase =" + shortOne.ToUpper());


            Console.WriteLine("Concatinate =" + shortOne + longOne);
            Console.WriteLine("remove =" + shortOne.Remove(3));
            Console.WriteLine("Insert =" + shortOne.Insert(3,"new"));
            Console.WriteLine("SubString =" + longOne.Substring(3,5));

            Console.ReadKey();








        }

    }
}
