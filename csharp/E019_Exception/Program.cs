using System;

namespace E019_Exception
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter temp: ");
            var temp = Convert.ToInt32(Console.ReadLine());
            try
            {
                Validate(temp);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }

            Console.WriteLine("After everything");
        }

        private static void Validate(int temp)
        {
            if (temp < 0)
            {
                throw new InvalidTemperatureException("Kelvin can not be negative");
            }
        }
    }
}