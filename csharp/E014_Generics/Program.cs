using System;

namespace E014_Generics
{
    public class Container<T>
    {
        public Container(T value)
        {
            Value = value;
        }
        
        public T Value { get; set; }
    }

    public static class Show
    {
        public static void PrintMessage<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
    
    internal static class Program
    {
        public static void Main()
        {
            Container<int> myContainer = new Container<int>(10);
            Console.WriteLine(myContainer.Value);
            
            Show.PrintMessage("Message");
            Show.PrintMessage(myContainer.Value);
        }
    }
}