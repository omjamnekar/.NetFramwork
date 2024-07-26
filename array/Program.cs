using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 number:");
            for(int i=0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();


        }
    }
}
