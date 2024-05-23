using System;

namespace _01b
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double baseTr, alturaTr;

            Console.WriteLine("Ingrese la base del triángulo:");
            baseTr = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo:");
            alturaTr = double.Parse(Console.ReadLine());

            CalcularYMostrarArea(baseTr, alturaTr);

            Console.ReadKey();
        }

        private static void CalcularYMostrarArea(double baseTr, double alturaTr)
        {
            double areaTr = (baseTr * alturaTr) / 2;
            Console.WriteLine($"\nEl área del triángulo es {areaTr}");
        }
    }
}