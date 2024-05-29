using System;

namespace _05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 5, 6, 7 } };

            int[,] resultados = BuscarMayoresYMenores(matriz);

            MostrarMatriz(matriz);
            Console.WriteLine("-----------------------------------");
            MostrarResultados(resultados);

            Console.ReadKey();
        }

        private static int[,] BuscarMayoresYMenores(int[,] datos)
        {
            int mayor = int.MinValue, menor = int.MaxValue;
            int[,] resultados = new int[2, 3];

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    var num = datos[i, j];

                    if (num > mayor)
                    {
                        mayor = num;
                        resultados[0, 0] = num;
                        resultados[0, 1] = i;
                        resultados[0, 2] = j;
                    }

                    if (num < menor)
                    {
                        menor = num;
                        resultados[1, 0] = num;
                        resultados[1, 1] = i;
                        resultados[1, 2] = j;
                    }
                }
            }

            return resultados;
        }

        private static void MostrarMatriz(int[,] datos)
        {
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    Console.Write($"{datos[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }

        private static void MostrarResultados(int[,] datos)
        {
            Console.WriteLine($"Mayor: {datos[0, 0]} - ({datos[0, 1]}, {datos[0, 2]})");
            Console.WriteLine($"Menor: {datos[1, 0]} - ({datos[1, 1]}, {datos[1, 2]})");
        }
    }
}