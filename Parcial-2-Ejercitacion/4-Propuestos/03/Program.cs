using System;

namespace _03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 5, 6, 7 } };

            int[] ultimaColumna = ObtenerUltimaColumna(matriz);

            MostrarMatriz(matriz);
            Console.WriteLine("\n");
            MostrarArray(ultimaColumna);

            Console.ReadKey();
        }

        private static int[] ObtenerUltimaColumna(int[,] datos)
        {
            int cantColumnas = datos.GetLength(1);
            int cantFilas = datos.GetLength(0);

            int[] ultimaColumna = new int[cantFilas];

            for (int i = 0; i < cantFilas; i++)
            {
                ultimaColumna[i] = datos[i, cantColumnas - 1];
            }

            return ultimaColumna;
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
    }
}