using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConcept_2
{
    class DuplicateArray
    {
        public static void Show()
        {
            int n , i;
            int[] arr = new int[100];

            Console.WriteLine("Entre the lenthe of Array");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i < n; i++)
            {
                Console.Write("Elements {0}: ",i);
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Elements in Array are ");
            for ( i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("The Duplicate Elements in this Array are : ");

            for(i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i]+" ");
                }
            }
            
            

            
        }
    }
    class ArayOddEvenSort
    {
        public static void Show()
        {
            int i, n;
            int[] arr = new int[100];

            Console.WriteLine("Entre the Length of Array");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Provide Elements in Array");

            for(i = 0; i < n; i++)
            {
                Console.Write("Element {0} ", i);   
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Element in Array are ");
            for( i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The odd Numbers in Array are");
            for (i = 0; i < n; i++)
            {
                if(arr[i]%2 == 0)
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Odd number in this Array are");
            for (i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Check duplicate Elements in the Array press 1 Otherwise to Check Odd Even Numbers in Press 2");

            int v = int.Parse(Console.ReadLine());

            if(v == 1)
            {
                DuplicateArray.Show();
            }
            else if(v == 2)
            {
                ArayOddEvenSort.Show();
            }
           


            Console.ReadLine();
        }
    }
}
