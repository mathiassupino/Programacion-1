using System;

namespace Parcial_2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] departamentos = new string[5]
            {
                "Costas Norte",
                "Colonias Sur",
                "Valle Centro",
                "Pueblos Este",
                "Sierra Oeste"
            },
            candidatos = new string[3]
            {
                "Nicolás I",
                "Mauricio P",
                "Javier L"
            };

            int[] totalPorCandidato = new int[candidatos.Length],
                  porcentajePorCandidato = new int[candidatos.Length],
                  totalPorDepartamento = new int[departamentos.Length],
                  dptosConMasYMenosVotos = new int[2];

            int totalDeVotos, dptoConMasVotos, dptoConMenosVotos, candidatoGanador;

            int[,] resultados = RegistrarResultados(departamentos, candidatos);

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("----- RESULTADOS POR DEPARTAMENTO --------------------------");
            Console.WriteLine("------------------------------------------------------------");

            MostrarResultados(departamentos, candidatos, resultados);

            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine("----- TOTALES POR CANDIDATO --------------------------------");
            Console.WriteLine("------------------------------------------------------------");

            totalPorCandidato = CalcularTotalPorCandidato(resultados);
            MostrarTotalPorCandidato(candidatos, totalPorCandidato);

            Console.WriteLine("\n\n------------------------------------------------------------");
            Console.WriteLine("----- PORCENTAJES POR CANDIDATO ----------------------------");
            Console.WriteLine("------------------------------------------------------------");

            totalDeVotos = CalcularTotalDeVotos(resultados);
            porcentajePorCandidato = CalcularPorcentajePorCandidato(totalDeVotos, totalPorCandidato);
            MostrarPorcentajePorCandidato(candidatos, porcentajePorCandidato);

            Console.WriteLine("\n\n------------------------------------------------------------");
            Console.WriteLine("----- TOTALES POR DEPARTAMENTO -----------------------------");
            Console.WriteLine("------------------------------------------------------------");

            totalPorDepartamento = CalcularTotalPorDepartamento(resultados);
            MostrarTotalPorDepartamento(departamentos, totalPorDepartamento);

            dptosConMasYMenosVotos = ObtenerDepartamentoConMasYMenosVotos(totalPorDepartamento);
            dptoConMasVotos = dptosConMasYMenosVotos[0];
            dptoConMenosVotos = dptosConMasYMenosVotos[1];

            Console.WriteLine("\n\n------------------------------------------------------------");
            Console.WriteLine($"----- DEPARTAMENTO CON MÁS VOTOS: {departamentos[dptoConMasVotos]}");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine($"----- DEPARTAMENTO CON MENOS VOTOS: {departamentos[dptoConMenosVotos]}");
            Console.WriteLine("------------------------------------------------------------");

            candidatoGanador = ObtenerCandidatoGanador(totalPorCandidato);

            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine($"----- CANDIDATO GANADOR: {candidatos[candidatoGanador]}");
            Console.WriteLine("------------------------------------------------------------");

            Console.ReadKey();
        }

        private static int[,] RegistrarResultados(string[] departamentos, string[] candidatos)
        {
            int[,] resultados = new int[departamentos.Length, candidatos.Length];

            for (int i = 0; i < resultados.GetLength(0); i++)
            {
                Console.WriteLine($"--- Departamento {departamentos[i]} --------------------");

                for (int j = 0; j < resultados.GetLength(1); j++)
                {
                    Console.Write($"Cantidad de votos para {candidatos[j]}: ");

                    resultados[i, j] = int.Parse(Console.ReadLine());
                }

                Console.Clear();
            }

            return resultados;
        }

        private static void MostrarResultados(string[] departamentos, string[] candidatos, int[,] resultados)
        {
            Console.Write("Departamento\t");

            for (int i = 0; i < candidatos.Length; i++)
            {
                Console.Write($"{candidatos[i]}\t");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < resultados.GetLength(0); i++)
            {
                Console.Write($"{departamentos[i]}\t");

                for (int j = 0; j < resultados.GetLength(1); j++)
                {
                    Console.Write($"{resultados[i, j]}\t\t");
                }

                Console.WriteLine("\n");
            }
        }

        private static int[] CalcularTotalPorCandidato(int[,] resultados)
        {
            int[] totales = new int[resultados.GetLength(1)];

            for (int i = 0; i < resultados.GetLength(1); i++)
            {
                int total = 0;

                for (int j = 0; j < resultados.GetLength(0); j++)
                {
                    total += resultados[j, i];
                }

                totales[i] = total;
            }

            return totales;
        }

        private static void MostrarTotalPorCandidato(string[] candidatos, int[] totales)
        {
            for (int i = 0; i < candidatos.Length; i++)
            {
                Console.Write($"{candidatos[i]}\t");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < totales.Length; i++)
            {
                Console.Write($"{totales[i]}\t\t");
            }
        }

        private static int CalcularTotalDeVotos(int[,] resultados)
        {
            int total = 0;

            for (int i = 0; i < resultados.GetLength(0); i++)
            {
                for (int j = 0; j < resultados.GetLength(1); j++)
                {
                    total += resultados[i, j];
                }
            }

            return total;
        }

        private static int[] CalcularPorcentajePorCandidato(int totalVotos, int[] totalPorCandidato)
        {
            int[] porcentajes = new int[totalPorCandidato.Length];

            for (int i = 0; i < totalPorCandidato.Length; i++)
            {
                porcentajes[i] = totalPorCandidato[i] * 100 / totalVotos;
            }

            return porcentajes;
        }

        private static void MostrarPorcentajePorCandidato(string[] candidatos, int[] porcentajes)
        {
            for (int i = 0; i < candidatos.Length; i++)
            {
                Console.Write($"{candidatos[i]}\t");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < porcentajes.Length; i++)
            {
                Console.Write($"{porcentajes[i]} %\t\t");
            }
        }

        private static int[] CalcularTotalPorDepartamento(int[,] resultados)
        {
            int[] totales = new int[resultados.GetLength(0)];

            for (int i = 0; i < resultados.GetLength(0); i++)
            {
                int total = 0;

                for (int j = 0; j < resultados.GetLength(1); j++)
                {
                    total += resultados[i, j];
                }

                totales[i] = total;
            }

            return totales;
        }

        private static void MostrarTotalPorDepartamento(string[] departamentos, int[] totales)
        {
            for (int i = 0; i < departamentos.Length; i++)
            {
                Console.Write($"{departamentos[i]}\t");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < totales.Length; i++)
            {
                Console.Write($"{totales[i]}\t\t");
            }
        }

        private static int[] ObtenerDepartamentoConMasYMenosVotos(int[] totales)
        {
            int mayorCantDeVotos = int.MinValue, menorCantDeVotos = int.MaxValue;
            int[] resultados = new int[2] { 0, 0 };

            for (int i = 0; i < totales.Length; i++)
            {
                if (totales[i] > mayorCantDeVotos)
                {
                    mayorCantDeVotos = totales[i];
                    resultados[0] = i;
                }

                if (totales[i] < menorCantDeVotos)
                {
                    menorCantDeVotos = totales[i];
                    resultados[1] = i;
                }
            }

            return resultados;
        }

        private static int ObtenerCandidatoGanador(int[] totales)
        {
            int ganador = 0, mayorCantVotos = int.MinValue;

            for (int i = 0; i < totales.Length; i++)
            {
                if (totales[i] > mayorCantVotos)
                {
                    mayorCantVotos = totales[i];
                    ganador = i;
                }
            }

            return ganador;
        }
    }
}