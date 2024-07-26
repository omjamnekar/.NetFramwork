using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string rev="";
            string num="";
            Console.WriteLine("Enter series of number: ");
            num =Console.ReadLine();
            
           int len = num.Length;
              
            for (int i = len-1; i>=0; i--)
            {
                rev = rev+ num[i];
               
            }
            


            if (rev == num)
            {
                Console.WriteLine("It is Palindrome");

            }
            else
            {
                Console.WriteLine("It is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
