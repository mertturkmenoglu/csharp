namespace E002_Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            System.Console.WriteLine("First: {0}\tSecond: {1}", a, b);
            System.Console.WriteLine(a + b);

            sbyte signed_byte = 15;
            short short_int = 500;
            int std_int = 1000;
            long long_integer = 100_000;
            byte unsigned_byte = 250;
            ushort unsigned_short = 65000;
            uint unsigned_int = 1000;
            ulong unsigned_long = 100_000;

            System.Console.WriteLine(signed_byte);
            System.Console.WriteLine(signed_byte.GetType());

            System.Console.WriteLine(short_int);
            System.Console.WriteLine(short_int.GetType());

            System.Console.WriteLine(std_int);
            System.Console.WriteLine(std_int.GetType());

            System.Console.WriteLine(long_integer);
            System.Console.WriteLine(long_integer.GetType());

            System.Console.WriteLine(unsigned_byte);
            System.Console.WriteLine(unsigned_byte.GetType());

            System.Console.WriteLine(unsigned_short);
            System.Console.WriteLine(unsigned_short.GetType());

            System.Console.WriteLine(unsigned_int);
            System.Console.WriteLine(unsigned_int.GetType());

            System.Console.WriteLine(unsigned_long);
            System.Console.WriteLine(unsigned_long.GetType());

            float single_precision = 3.14f;
            double double_precision = 3.1415;

            System.Console.WriteLine(single_precision);
            System.Console.WriteLine(single_precision.GetType());

            System.Console.WriteLine(double_precision);
            System.Console.WriteLine(double_precision.GetType());

            decimal d_128_bit_int = 0.0M;
            char two_byte_char = 'a';

            System.Console.WriteLine(d_128_bit_int);
            System.Console.WriteLine(d_128_bit_int.GetType());

            System.Console.WriteLine(two_byte_char);
            System.Console.WriteLine(two_byte_char.GetType());

            bool boolean_value = true;

            System.Console.WriteLine(boolean_value);
            System.Console.WriteLine(boolean_value.GetType());

            string my_str = "Emily";
            my_str += " loves";
            my_str += " me.";

            System.Console.WriteLine(my_str);
            System.Console.WriteLine(my_str.GetType());

            object generic_obj;
            generic_obj = 10;
            System.Console.WriteLine(generic_obj);
            System.Console.WriteLine(generic_obj.GetType());
            generic_obj = true;
            System.Console.WriteLine(generic_obj);
            System.Console.WriteLine(generic_obj.GetType());
        }
    }
}
