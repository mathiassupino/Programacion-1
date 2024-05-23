using System;

namespace _05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] valores = new int[6];
            int sumaPositivos = 0, cantPositivos = 0,
                sumaImpares = 0, mayor = int.MinValue, posicionMayor = 0,
                menor = int.MaxValue, posicionMenor = 0;
            double promedioPositivos;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Ingrese un número:");
                valores[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > 0)
                {
                    sumaPositivos += valores[i];
                    cantPositivos++;
                }

                if (i % 2 != 0)
                    sumaImpares += valores[i];

                if (valores[i] > mayor)
                {
                    mayor = valores[i];
                    posicionMayor = i;
                }

                if (valores[i] < menor)
                {
                    menor = valores[i];
                    posicionMenor = i;
                }
            }

            Console.Clear();

            promedioPositivos = (double)sumaPositivos / cantPositivos;

            Console.WriteLine($"Promedio de positivos: {promedioPositivos:F2}");
            Console.WriteLine($"Sumatoria de posiciones impares: {sumaImpares}");
            Console.WriteLine($"Mayor: {mayor} - Posición {posicionMayor}");
            Console.WriteLine($"Menor: {menor} - Posición {posicionMenor}");

            Console.ReadKey();
        }
    }
}