using System;

namespace _1_02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrizOriginal = new int[5, 6]
            {
                { 12, 78, 34, 89, 45, 90 },
                { 43, 43, 54, 65, 76, 87 },
                { 11, 33, 55, 77, 99, 22 },
                { 45, 67, 78, 89, 90, 01 },
                { 32, 32, 43, 54, 65, 76 }
            };
            int[,] matrizOrdenada = new int[5, 6];

            for (int i = 0; i < matrizOriginal.GetLength(0); i++)
            {
                int[] vectorTemporal = new int[6];
                for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                {
                    vectorTemporal[j] = matrizOriginal[i, j];
                }

                Array.Sort(vectorTemporal);

                for (int z = 0; z < vectorTemporal.Length; z++)
                {
                    matrizOrdenada[i, z] = vectorTemporal[z];
                }
            }

            for (int i = 0; i < matrizOrdenada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizOrdenada.GetLength(1); j++)
                {
                    Console.Write($"\t{matrizOrdenada[i, j]}");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}