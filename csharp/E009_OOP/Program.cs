using System;

namespace E009_OOP
{
    public class Student
    {
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
            Console.WriteLine("Student constructor invoked");
        }

        public string Name { get; set; }

        public int Id { get; set; }

        // Destructor can not take any modifier
        ~Student()
        {
            Console.WriteLine("Student destructor invoked");
        }
    }

    public static class MainClass
    {
        public static void Main(string[] args)
        {
            var emily = new Student("Emily", 1);
            Console.WriteLine("Type: " + emily.GetType());
            Console.WriteLine("Name: " + emily.Name);
            Console.WriteLine("ID: " + emily.Id);
            emily.Name = "Emily T.";
            emily.Id = 2;
            Console.WriteLine("Name: " + emily.Name);
            Console.WriteLine("ID: " + emily.Id);
        }
    }

}