using System;

namespace _01a
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double baseTr, alturaTr, areaTr;

            Console.WriteLine("Ingrese la base del triángulo:");
            baseTr = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo:");
            alturaTr = double.Parse(Console.ReadLine());

            areaTr = CalcularArea(baseTr, alturaTr);

            Console.WriteLine($"\nEl área del triángulo es {areaTr}");

            Console.ReadKey();
        }

        private static double CalcularArea(double baseTr, double alturaTr)
        {
            return (baseTr * alturaTr) / 2;
        }
    }
}