using System;

namespace E015_Abstraction
{
    public interface INumber
    {
        void PrintValue();
    }

    public class Integer : INumber
    {
        public Integer(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public void PrintValue()
        {
            Console.WriteLine("Integer: " + Value);
        }
    }

    public class Floating : INumber
    {
        public Floating(float value)
        {
            Value = value;
        }

        public float Value { get; set; }

        public void PrintValue()
        {
            Console.WriteLine("Floating: " + Value);
        }
    }
}