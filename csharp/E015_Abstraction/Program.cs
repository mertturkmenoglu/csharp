namespace E015_Abstraction
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Vehicle sv = new SpecialVehicle();
            Vehicle pv = new PublicVehicle();
            
            sv.PrintMessage();
            pv.PrintMessage();
            sv.PrintPlate();
            pv.PrintPlate();
            
            INumber intNumber = new Integer(42);
            Floating floating = new Floating(3.14f);
            
            intNumber.PrintValue();
            floating.PrintValue();
        }
    }
}