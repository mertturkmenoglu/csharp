using System;

namespace E005_Arrays
{
    internal static class Program
    {
        static void printArray(int[] arr)
        {
            foreach (var VARIABLE in arr)
            {
                Console.WriteLine(VARIABLE);   
            }
        }
        public static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (var i = 0; i < n; i++)
            {
                arr[i] = i;
            }

            int[] arr1 = {1, 2, 3};

            Console.WriteLine("Print arr1");
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("Print arr");
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Print arr1");
            printArray(arr1);
            
        }
    }
}