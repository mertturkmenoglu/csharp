using System;

namespace E017_MergeSort
{
    internal static class Program
    {
        public static void Main()
        {
            var gen = new Random();
            var n = gen.Next(5, 10);
            var arr = new int[n];
            
            for (var i = 0; i < n; i++)
            {
                arr[i] = gen.Next(-n, n);
            }

            foreach (var num in arr)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine();
            
            Sort.MergeSort(arr, 0, n - 1);
            
            foreach (var num in arr)
            {
                Console.Write(num + "\t");
            }

            Console.WriteLine();
        }
    }
}