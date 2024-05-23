using System;

namespace _2_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[,] notas = new double[5, 3]
            {
                { 7.0, 8.0, 9.0 },
                { 4.0, 5.0, 6.0 },
                { 1.0, 2.0, 3.0 },
                { 4.0, 5.0, 6.0 },
                { 7.0, 8.0, 9.0 }
            },
            resultados = new double[2, 3]
            {
                { double.MaxValue, 0, 0},
                { double.MinValue, 0, 0}
            };
            double sumaTotal = 0.0, promedio;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    var nota = notas[i, j];

                    sumaTotal += nota;

                    if (nota < resultados[0, 0])
                    {
                        resultados[0, 0] = nota;
                        resultados[0, 1] = i + 1;
                        resultados[0, 2] = j + 1;
                    }

                    if (nota > resultados[1, 0])
                    {
                        resultados[1, 0] = nota;
                        resultados[1, 1] = i + 1;
                        resultados[1, 2] = j + 1;
                    }
                }
            }

            promedio = sumaTotal / (notas.GetLength(0) * notas.GetLength(1));

            Console.WriteLine($"Mayor nota: {resultados[0, 0]} - [{resultados[0, 1]},{resultados[0, 2]}]");
            Console.WriteLine($"Mayor nota: {resultados[1, 0]} - [{resultados[1, 1]},{resultados[1, 2]}]");
            Console.WriteLine($"Promedio total: {promedio}");

            Console.ReadKey();
        }
    }
}