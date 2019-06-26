using System;

namespace E006_Matrix
{
    internal static class Program
    {
        private static void PrintMatrix(int[][] mtr)
        {
            for (var i = 0; i < mtr.Length; i++)
            {
                for (var j = 0; j < mtr[i].Length; j++)
                {
                    Console.Write(mtr[i][j]);
                }
                Console.WriteLine();
            }
        }
        
        private static void PrintMtr(int[,] mtr)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(mtr[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        public static void Main()
        {
            int[,] mtr=new int[3,3];

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    mtr[i, j] = i * 3 + j;
                }
            }
            
            PrintMtr(mtr);

            var n = 3;
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            PrintMatrix(matrix);
        }
    }
}