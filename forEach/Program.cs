using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr =new int[10] {1,2,3,4,5,5,3,4,5,6};

            foreach (int i in arr) { 
                
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
