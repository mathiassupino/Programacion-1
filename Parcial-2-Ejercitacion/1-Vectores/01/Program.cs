using System;

namespace _01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int num, suma = 0;
            double promedio;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escribe un numero:");
                num = int.Parse(Console.ReadLine());
                suma += num;
                numeros[i] = num;
            }

            promedio = suma / 5f;
            Console.Clear();

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio}");

            Console.ReadKey();
        }
    }
}