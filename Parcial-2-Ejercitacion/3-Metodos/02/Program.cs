using System;

namespace _02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int operacion;
            double num1, num2, resultado;

            Console.WriteLine("--- OPERACIONES DISPONIBLES ----------------");
            Console.WriteLine("0 - Suma");
            Console.WriteLine("1 - Resta");
            Console.WriteLine("2 - Multiplicación");
            Console.WriteLine("3 - División");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("\nIngrese la operación a realizar:");
            operacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            num2 = double.Parse(Console.ReadLine());

            resultado = Calcular(operacion, num1, num2);

            Console.WriteLine($"\nEl resultado de la operación es {resultado}");

            Console.ReadKey();
        }

        private static double Calcular(int operacion, double num1, double num2)
        {
            switch (operacion)
            {
                case 0:
                    return num1 + num2;

                case 1:
                    return num1 - num2;

                case 2:
                    return num1 * num2;

                case 3:
                    return num1 / num2;

                default:
                    return 0;
            }
        }
    }
}