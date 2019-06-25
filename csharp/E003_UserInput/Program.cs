using System;

namespace E003_UserInput
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: " + name + "\tAge: " + age);

            Console.WriteLine(age >= 18 ? "You are an adult" : "You are not an adult");
        }
    }
}