using System;

namespace E012_Inheritance
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            Console.WriteLine("Person constructor");
            Name = name;
            _name = name;
        }

        public string Name
        {
            get
            {
                Console.WriteLine("Get Name");
                return _name;
            }

            set
            {
                Console.WriteLine("Set Name");
                _name = value;
            }
        }
    }

    public class Teacher : Person
    {
        private int _age;

        public Teacher(string name, int age) : base(name)
        {
            Console.WriteLine("Teacher constructor");
            Age = age;
            _age = age;
        }

        public int Age
        {
            get
            {
                Console.WriteLine("Get Age");
                return _age;
            }
            set
            {
                if (value <= 0) 
                    throw new ArgumentOutOfRangeException(nameof(value));
                Console.WriteLine("Set Age");
                _age = value;
            }
        }
      
    }
}