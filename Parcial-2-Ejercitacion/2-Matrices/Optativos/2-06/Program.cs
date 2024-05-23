using System;

namespace _2_06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5]
            {
                {  4, 10,  6,  9, 13 },
                { 97, 29,  2, 15, 73 },
                { 17, 96, 32, 75, 38 },
                { 73, 95, 12, 55, 34 },
                { 78, 19, 28, 56, 93 }
            };
            int suma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (i != 2)
                {
                    suma += matriz[i, i];
                    suma += matriz[i, matriz.GetLength(1) - 1 - i];
                }
            }

            Console.WriteLine($"Suma: {suma}");

            Console.ReadKey();
        }
    }
}