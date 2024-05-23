using System;

namespace _1_05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[,] datos = new string[3, 4];
            string[] columnas = new string[4]
            {
                "Nombre", "Apellido", "Dirección", "Teléfono"
            };

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                Console.WriteLine("--- NUEVO ALUMNO -------");
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese {columnas[j]}:");
                    datos[i, j] = Console.ReadLine();
                }
                Console.Clear();
            }

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    Console.Write($"{datos[i, j]}\t");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}