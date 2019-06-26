using System;

namespace E010_Struct
{
    internal struct Shape
    {
        public Shape(double area, double volume)
        {
            Area = area;
            Volume = volume;
        }

        public double Area { get; }
        public double Volume { get; }
    }
    
    
    internal static class Program
    {
        public static void Main()
        {
            Shape s1 = new Shape(10, 50);
            Shape s2 = new Shape(5, 15);
            Console.WriteLine("s1 area: " + s1.Area);
            Console.WriteLine("s1 volume: " + s1.Volume);
            
            Console.WriteLine("s2 area: " + s2.Area);
            Console.WriteLine("s2 volume: "+ s2.Volume);
        }
    }
}