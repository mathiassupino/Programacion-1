using System;

namespace _03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cantidadDeElementos = 6, num, suma = 0, cantPares = 0, cantImpares = 0;
            int[] valores = new int[cantidadDeElementos];
            float promedio, porcPares, porcImpares;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());

                suma += num;
                valores[i] = num;

                if (num % 2 == 0)
                    cantPares++;
                else
                    cantImpares++;
            }

            Console.Clear();

            promedio = (float)suma / cantidadDeElementos;
            porcPares = (float)cantPares / cantidadDeElementos * 100;
            porcImpares = (float)cantImpares / cantidadDeElementos * 100;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Pares: {porcPares:F2}%");
            Console.WriteLine($"Impares: {porcImpares:F2}%");

            Console.ReadKey();
        }
    }
}