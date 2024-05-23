using System;

namespace _1_03
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
            int[] pares = new int[2] { 0, 0 }, impares = new int[2] { 0, 0 };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    var valor = matriz[i, j];
                    if (valor % 2 == 0)
                    {
                        pares[0] = pares[0] + valor;
                        pares[1]++;
                    }
                    else
                    {
                        impares[0] = impares[0] + valor;
                        impares[1]++;
                    }
                }
            }

            Console.WriteLine($"Pares ({pares[1]}) -> Suma: {pares[0]}");
            Console.WriteLine($"Impares ({impares[1]}) -> Suma: {impares[0]}");

            Console.ReadKey();
        }
    }
}