using System;

namespace E015_Abstraction
{
    public abstract class Vehicle
    {
        public abstract void PrintPlate();

        public void PrintMessage()
        {
            Console.WriteLine("Do not forget to fasten your seat belt.");
        }
    }

    public class SpecialVehicle : Vehicle
    {
        public override void PrintPlate()
        {
            Console.WriteLine("Special Vehicle - 24601");
        }
    }

    public class PublicVehicle : Vehicle
    {
        public override void PrintPlate()
        {
            Console.WriteLine("Public Transport - 1234");
        }
    }
}