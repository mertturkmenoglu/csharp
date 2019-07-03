using System;
using System.IO;

namespace E020_FileIO
{
    internal static class Program
    {
        public static void Main()
        {
            
            FileStream f1 = new FileStream("/home/mert/FileStream.txt", FileMode.OpenOrCreate);  
            // Write all capital letters
            for (int i = 65; i <= 90; i++)  
            {  
                f1.WriteByte((byte)i);  
            }  
            f1.Close();  
            
            FileStream f2 =new FileStream("/home/mert/StreamWriter.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f2);
            
            sw.WriteLine("Just one line");
            sw.WriteLine("Second line");
            sw.Close();
            f2.Close();
            
            FileStream f3 = new FileStream("/home/mert/StreamReader.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f3);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            
            sr.Close();
            f3.Close();
        }
    }
}