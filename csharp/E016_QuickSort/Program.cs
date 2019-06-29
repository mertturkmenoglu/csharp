using System;

namespace E016_QuickSort
{
    internal static class Program
    {
        public static void Main()
        {
            int[] arr = {5, 7, 3, 2, -1, 27, 9, 2};
            foreach (var num in arr)
            {
                Console.Write(num + "\t");
            }

            Sort.QuickSort(arr, 0, 7);
            Console.WriteLine();
            
            
            foreach (var num in arr)
            {
                Console.Write(num + "\t");
            }
        }
    }
}