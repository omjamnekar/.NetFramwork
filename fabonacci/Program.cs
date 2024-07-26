using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numb = { 0,1 };
            int limit = 0;
            
            Console.WriteLine("Enter linit:");
            limit =Convert.ToInt32(Console.ReadLine());
            limit = limit - 2;
            //8
            
            for(int i =1;<=limit; i++)
            {
                
                int add=
                numb.Append(add); //1 2 

            }
            Console.WriteLine("Fobinacci"+numb);
            Console.ReadKey();

        }
    }
}
