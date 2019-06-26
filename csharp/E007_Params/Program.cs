using System;

namespace E007_Params
{
    internal static class Program
    {
        private static void PrintInfos(int age, params string[] values)
        {
            Console.WriteLine("Age: " + age);
            foreach (var value in values)
            {
                Console.WriteLine("Value: " + value);
            }
        }
        
        public static void Main()
        {
            string[] strings = {"Emily", "London", "Yellow"};
            PrintInfos(35, strings);
            PrintInfos(35, "Emily", "London", "Hello");
        }
    }
}