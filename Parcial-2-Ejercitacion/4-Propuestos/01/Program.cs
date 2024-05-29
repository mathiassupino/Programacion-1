using System;

namespace _01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int tamanio, cantPares = 0, cantImpares = 0;

            Console.WriteLine("¿Cuántos elementos contendrá la lista?");
            tamanio = int.Parse(Console.ReadLine());
            Console.Clear();

            int[] numeros = new int[tamanio];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número:");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                    cantPares++;
                else
                    cantImpares++;

                numeros[i] = numero;
            }
            Console.Clear();

            MostrarElementos(numeros);

            Console.WriteLine($"Cantidad de números pares: {cantPares}");
            Console.WriteLine($"Cantidad de números impares: {cantImpares}");

            Console.ReadKey();
        }

        private static void MostrarElementos(int[] listado)
        {
            Console.WriteLine("-- ELEMENTOS INGRESADOS --------");
            for (int i = 0; i < listado.Length; i++)
            {
                Console.WriteLine($"{listado[i]}");
            }
            Console.WriteLine("--------------------------------");
        }
    }
}