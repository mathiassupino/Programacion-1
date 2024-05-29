using System;

namespace _02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] vector1 = new int[] { 1, 2, 3, 4, 5 },
                  vector2 = new int[] { 7, 5, 8, 1, 5 };

            int[] vector3 = SumarVectores(vector1, vector2);

            MostrarArray(vector1);
            MostrarArray(vector2);

            Array.Sort(vector3);

            MostrarArray(vector3);

            Console.ReadKey();
        }

        private static int[] SumarVectores(int[] vector1, int[] vector2)
        {
            int[] vectorSumas = new int[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                vectorSumas[i] = vector1[i] + vector2[i];
            }
            return vectorSumas;
        }

        private static void MostrarArray(int[] listado)
        {
            Console.Write("[");
            for (int i = 0; i < listado.Length; i++)
            {
                Console.Write($"{listado[i]}\t");
            }
            Console.Write("]\n");
        }
    }
}