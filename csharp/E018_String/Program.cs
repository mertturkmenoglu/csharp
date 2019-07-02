/**
 * System.String methods
 */

using System;
using System.Linq;

namespace E018_String
{
    internal static class Program
    {
        public static void Main()
        {
            // Clone()
            string str1 = "Emily";
            string str2 = (string) str1.Clone();
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            
            // Compare()
            var result = String.Compare(str1, str2);
            switch (result)
            {
                case -1:
                    Console.WriteLine("str1 < str2");
                    break;
                case 0:
                    Console.WriteLine("str1 == str2");
                    break;
                case 1:
                    Console.WriteLine("str1 > str2");
                    break;
                default:
                    Console.WriteLine("You should not be here");
                    break;
            }

            result = String.CompareOrdinal(str1, str2);
            if (result < 0)
            {
                Console.WriteLine("str1 < str2");
            } else if (result == 0)
            {
                Console.WriteLine("str1 == str2");
            }
            else
            {
                Console.WriteLine("str1 > str2");
            }

            Console.WriteLine(String.Concat(str1, str2));
            Console.WriteLine(str1.Contains("mi"));
            Console.WriteLine(str1.EndsWith("ly"));
            Console.WriteLine(str1.Equals(str2));
            var formatted = string.Format("{0} loves {1}", str1, str2);
            Console.WriteLine(formatted);

            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str1.GetTypeCode());
            Console.WriteLine(str1.IndexOf("i"));
            Console.WriteLine(str2.Insert(0, "I love you "));
            string[] arr = {"Emily", "where", "are", "you?"};
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(str1.StartsWith("Emi"));
            string[] words = "Emily I am worried about you".Split(' ');
            foreach (var str in words)
            {
                Console.WriteLine(str);
            }

            var charArr = "Emily is beautiful".ToCharArray();
            foreach (var ch in charArr)
            {
                Console.WriteLine(ch);
            }

            int num = 42;
            Console.WriteLine(num.ToString());
        }
    }
}