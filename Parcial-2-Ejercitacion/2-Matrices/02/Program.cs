using System;

namespace _02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[,] ventas = new double[5, 6]
            {
                { 123.45, 678.90, 234.56, 789.12, 345.67, 890.23 },
                { 432.10, 543.21, 654.32, 765.43, 876.54, 987.65 },
                { 111.22, 333.44, 555.66, 777.88, 999.99, 222.33 },
                { 456.78, 567.89, 678.01, 789.12, 890.23, 901.34 },
                { 321.01, 432.10, 543.21, 654.32, 765.43, 876.54 }
            };
            double[] promedios = new double[5];
            double sumaPromedios = 0.0, promedioGral;

            Console.WriteLine("----- VENTAS MENSUALES -----");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"--- Sucursal {i + 1}");
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Mes {j + 1}: $ {ventas[i, j]:F2}");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("----- PROMEDIO ANUAL -----");
            for (int i = 0; i < 5; i++)
            {
                double suma = 0.0, promedio;
                for (int j = 0; j < 6; j++)
                {
                    suma += ventas[i, j];
                }
                promedio = suma / 6.0;
                promedios[i] = promedio;
                Console.WriteLine($"--- Sucursal {i + 1}: $ {promedio:F2}");
            }

            Console.WriteLine("\n----- PROMEDIO GENERAL -----");
            for (int i = 0; i < 5; i++)
            {
                sumaPromedios += promedios[i];
            }
            promedioGral = sumaPromedios / 5;
            Console.WriteLine($"$ {promedioGral:F2}");

            Console.WriteLine("\n----- SUCURSALES CON MAYOR PROMEDIO AL GRAL -----");
            for (int i = 0; i < 5; i++)
            {
                if (promedios[i] > promedioGral)
                    Console.WriteLine($"- Sucursal {i + 1}: $ {promedios[i]:F2}");
            }

            Console.ReadKey();
        }
    }
}