using System;

namespace _04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] nombres = new string[3];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Escribe un nombre:");
                nombres[i] = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("NOMBRES:");
            ImprimirElementos(nombres);

            Array.Sort(nombres);

            Console.WriteLine("\nNOMBRES ORDENADOS:");
            ImprimirElementos(nombres);

            Console.ReadKey();
        }

        private static void ImprimirElementos(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"- {array[i]}");
            }
        }
    }
}