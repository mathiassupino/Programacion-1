using System;

namespace _04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float[] estaturas = { 1.62f, 1.5f, 1.9f, 1.85f, 1.74f };
            float mayorEstatura = float.MinValue, menorEstatura = float.MaxValue, promedio, suma = 0f;

            for (int i = 0; i < estaturas.Length; i++)
            {
                suma += estaturas[i];

                if (i == 0)
                {
                    mayorEstatura = estaturas[i];
                    menorEstatura = estaturas[i];
                }
                else
                {
                    if (estaturas[i] > mayorEstatura)
                        mayorEstatura = estaturas[i];
                    else if (estaturas[i] < menorEstatura)
                        menorEstatura = estaturas[i];
                }
            }

            promedio = suma / estaturas.Length;

            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Mayor: {mayorEstatura:F2}");
            Console.WriteLine($"Menor: {menorEstatura:F2}");

            Console.WriteLine($"Estaturas menores al promedio:");
            for (int i = 0; i < estaturas.Length; i++)
            {
                if (estaturas[i] <= promedio)
                    Console.WriteLine($"* {estaturas[i]}");
            }

            Console.ReadKey();
        }
    }
}