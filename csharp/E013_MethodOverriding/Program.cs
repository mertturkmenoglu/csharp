using System;

namespace E013_MethodOverriding
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing Rectangle");
        }
    }
    
    internal static class Program
    {
        public static void Main()
        {
            Shape s1 = new Shape();
            Shape s2 = new Rectangle();
            Rectangle r1 = new Rectangle();
            
            s1.Draw();
            s2.Draw();
            r1.Draw();
        }
    }
}