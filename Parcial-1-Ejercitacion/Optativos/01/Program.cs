using System;

namespace Ej_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Desarrollar un algoritmo que calcule el factorial de un número N.

            int num, factorial;

            Console.WriteLine("Escriba un numero:");
            num = int.Parse(Console.ReadLine());

            factorial = num;

            for (int i = num - 1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"\nEl factorial de {num} es {factorial}.");
            Console.ReadKey();
        }
    }
}