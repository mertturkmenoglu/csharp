using System;

namespace E011_Enum
{
    public enum EyeColor
    {
        Green,
        Blue,
        Brown,
        Black,
        Hazel
    }

    public class Person
    {
        public Person(string name, EyeColor eyeColor)
        {
            Name = name;
            Eye = eyeColor;
        }

        public EyeColor Eye { get; set; }

        public string Name { get; }
    }
    
    internal static class Program
    {
        public static void Main()
        {
            Person person = new Person("Emily", EyeColor.Green);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Eye);
            person.Eye = EyeColor.Hazel;
            Console.WriteLine(person.Eye);
        }
    }
}