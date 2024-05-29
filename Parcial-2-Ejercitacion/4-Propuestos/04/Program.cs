using System;

namespace _04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 5, 6, 7 } };

            int[,] matrizInvertida = InvertirFilasYColumnas(matriz);

            double promedio = CalcularPromedio(matriz);

            MostrarMatriz(matrizInvertida);

            Console.WriteLine($"\nPromedio: {promedio}");

            Console.ReadKey();
        }

        private static int[,] InvertirFilasYColumnas(int[,] datos)
        {
            int cantFilas = datos.GetLength(0);
            int cantColumnas = datos.GetLength(1);

            int[,] resultado = new int[cantColumnas, cantFilas];

            for (int i = 0; i < cantFilas; i++)
            {
                for (int j = 0; j < cantColumnas; j++)
                {
                    resultado[j, i] = datos[i, j];
                }
            }

            return resultado;
        }

        private static double CalcularPromedio(int[,] datos)
        {
            int cantFilas = datos.GetLength(0),
                cantColumnas = datos.GetLength(1),
                sumaTotal = 0;

            double cantidadElementos = cantFilas * cantColumnas;

            for (int i = 0; i < cantFilas; i++)
            {
                for (int j = 0; j < cantColumnas; j++)
                {
                    sumaTotal += datos[i, j];
                }
            }

            return sumaTotal / cantidadElementos;
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
    }
}