using System;

namespace _1_04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5]
            {
                { 7, 8, 9, 1, 2 },
                { 4, 5, 6, 7, 8 },
                { 1, 2, 3, 4, 5 },
                { 4, 5, 6, 7, 8 },
                { 7, 8, 9, 1, 2 }
            };
            int suma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                        suma += matriz[i, j];
                }
            }

            Console.WriteLine($"Suma final: {suma}");

            Console.ReadKey();
        }
    }
}