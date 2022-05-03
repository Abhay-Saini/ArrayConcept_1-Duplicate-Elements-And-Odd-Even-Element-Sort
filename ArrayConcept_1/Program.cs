using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConcept_1   // Reverse array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];

            Console.WriteLine("Entre the length of Array");

            int n = Convert.ToInt32(Console.ReadLine());
             
            for(int i = 0; i < n; i++)
            {
                Console.Write("Elements {0} ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Elements in array are : ");

            for(int i = 0; i < n; i++)
            {
                Console.Write(" {0}",arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Array in reverse order :");

            for(int i = n - 1; i >=0; i--)
            {
                Console.Write(arr[i] + " ");
            }


            Console.ReadLine();

        }
    }
}
