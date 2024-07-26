using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList  arr  = new ArrayList();
            arr.Add("Mumbai");
            arr.Add("Delhi");
            arr.Add("Goa");
            arr.Add("Pune");
            arr.Add("Bengluru");
            arr.Insert(2,"Nashik");
            


            
            for (int i = 0; i < arr.Count; i++) {

               Console.WriteLine(arr[i]);

            }
            Console.WriteLine("Capacity: "+arr.Capacity);
            Console.WriteLine("Count: "+arr.Count);
            Console.WriteLine();

            // remove
            arr.RemoveAt(4);
            arr.Remove("Nashik");


            for (int i = 0; i < arr.Count; i++)
            {

                Console.WriteLine(arr[i]);

            }

            Console.WriteLine();

            arr.Sort();
            for (int i = 0; i < arr.Count; i++)
            {

                Console.WriteLine(arr[i]);

            }

            Console.WriteLine();

            // 
            Console.ReadKey();

        }
    }
}
