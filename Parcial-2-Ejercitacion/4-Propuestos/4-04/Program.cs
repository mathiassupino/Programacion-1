using System;

namespace _4_04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] resultados = new int[15, 4]
            {
                { 10, 20, 30, 40 },
                { 50, 60, 70, 80 },
                { 90, 10, 15, 25 },
                { 35, 45, 55, 65 },
                { 75, 85, 95, 51 },
                { 15, 25, 35, 45 },
                { 55, 65, 75, 85 },
                { 95, 51, 15, 25 },
                { 35, 45, 55, 65 },
                { 75, 85, 95, 51 },
                { 15, 25, 35, 45 },
                { 55, 65, 75, 85 },
                { 95, 51, 15, 25 },
                { 35, 45, 55, 65 },
                { 75, 85, 95, 51 }
            };
            int[] totalesIndividuales = new int[4];
            int total = 0;

            MostrarMatriz(resultados);

            for (int i = 0; i < resultados.GetLength(1); i++)
            {
                var totalCandidato = 0;

                for (int j = 0; j < resultados.GetLength(0); j++)
                {
                    var votos = resultados[j, i];
                    totalCandidato += votos;
                }

                total += totalCandidato;
                totalesIndividuales[i] = totalCandidato;
            }

            Console.ReadKey();
        }

        private static void MostrarMatriz(int[,] datos)
        {
            Console.Write("\t\t");
            for (int j = 0; j < datos.GetLength(1); j++)
            {
                Console.Write($"Cand{j + 1}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                Console.Write($"Escuela n°{i + 1} |\t");
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    Console.Write($"{datos[i, j]}\t");
                }
                Console.Write("\n");
            }
        }
    }
}