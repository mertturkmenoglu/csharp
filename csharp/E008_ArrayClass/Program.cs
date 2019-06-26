using System;

namespace E008_ArrayClass
{
    internal static class Program
    {
        private static void PrintArray(int[] array)
        {
            foreach (var value in array)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }
        
        
        public static void Main()
        {
            int[] arr1 = { 6, 1, 3, 4, 2, 5 };
            int[] arr2 = new int[6];
            PrintArray(arr1);
            PrintArray(arr2);
            Console.WriteLine("--------");
            
            Console.WriteLine("Length of the first array: " + arr1.Length);
            Console.WriteLine("Length of the second array: " + arr2.Length);
            Console.WriteLine("--------");
            
            Array.Sort(arr1);  
            Console.WriteLine("After sorting: ");
            PrintArray(arr1);
            Console.WriteLine("--------");

            Console.WriteLine("Index of 3: " + Array.IndexOf(arr1,3));
            Console.WriteLine("--------");
            
            Array.Copy(arr1, arr2, arr1.Length);  
            Console.WriteLine("After copying, second array: ");
            PrintArray(arr2);
            Console.WriteLine("--------");
            
            Array.Reverse(arr1);  
            Console.Write("First array reverse: ");
            PrintArray(arr1);
        }
    }
}








