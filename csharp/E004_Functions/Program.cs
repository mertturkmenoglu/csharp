using System;

namespace E004_Functions
{
    internal static class Program
    {
        private static void MulValue(int value)
        {
            value *= 2;
            Console.WriteLine("Inside function: " + value);
        }
        
        // It is similar to C++ references
        private static void MulRef(ref int value)
        {
            value *= 2;
            Console.WriteLine("Inside function: " + value);
        }
        
        public static void Main()
        {
            var val = 5;
            MulValue(val);
            Console.WriteLine("Inside main: " + val);
            
            // Here we must use ref keyword
            MulRef(ref val);
            Console.WriteLine("Inside main: " + val);
        }
    }
}