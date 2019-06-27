using System;

namespace E012_Inheritance
{

    internal static class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person("Nobody");
            Teacher t = new Teacher("Emily", 35);

            Console.WriteLine(p.Name);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Age);
            t.Name = "Emily T.";
            t.Age = 32;
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Age);
        }
    }
}