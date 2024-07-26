using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[] { 1};
            arr[1] = new int[] { 2, 3 };
            arr[2] = new int[] { 4, 5, 6 };
            arr[3] = new int[] {7,8,9,10 };


            for (int i = 0; i < arr.Length; i++)
            {
             
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
