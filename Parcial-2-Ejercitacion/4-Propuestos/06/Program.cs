using System;

namespace _06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[,] { { 1, 2, 3, 8 }, { 4, 5, 6, 4 }, { 5, 2, 7, 5 }, { 7, 1, 4, 9 } };

            int[] resultado = ObtenerDiagonalInversa(matriz);
            int suma = SumarElementos(resultado);

            MostrarMatriz(matriz);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine("-----------------------------------");
            MostrarArray(resultado);
            Console.WriteLine("-----------------------------------");
            Array.Sort(resultado);
            MostrarArray(resultado);

            Console.ReadKey();
        }

        private static int[] ObtenerDiagonalInversa(int[,] datos)
        {
            int tamanio = datos.GetLength(0);
            int[] resultado = new int[tamanio];

            for (int i = 0; i < tamanio; i++)
            {
                resultado[i] = datos[i, (tamanio - 1) - i];
            }

            return resultado;
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

        private static void MostrarArray(int[] listado)
        {
            for (int i = 0; i < listado.Length; i++)
            {
                Console.Write($"{listado[i]}\t");
            }
            Console.WriteLine("\n");
        }

        private static int SumarElementos(int[] datos)
        {
            int sum = 0;

            for (int i = 0; i < datos.Length; i++)
            {
                sum += datos[i];
            }

            return sum;
        }
    }
}