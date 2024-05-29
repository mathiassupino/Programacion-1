using System;

namespace _2_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[,] datos = ObtenerDatos();
            int[] sueldosAcumulados = CalcularAcumulados(datos);
            int total = CalcularTotal(sueldosAcumulados),
                mayorSueldo = CalcularPosicionMayor(sueldosAcumulados);

            MostrarMatriz(datos);
            Console.WriteLine("------------------------------------");
            MostrarArray(sueldosAcumulados);
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Mayor acumulado: {sueldosAcumulados[mayorSueldo]} ({datos[mayorSueldo, 0]})");

            Console.ReadKey();
        }

        private static string[,] ObtenerDatos()
        {
            string[,] datos = new string[5, 4];

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                Console.WriteLine($"--- OPERARIO {i + 1} -------------");
                Console.WriteLine("Nombre:");
                datos[i, 0] = Console.ReadLine();
                Console.WriteLine("Sueldo mes 1:");
                datos[i, 1] = Console.ReadLine();
                Console.WriteLine("Sueldo mes 2:");
                datos[i, 2] = Console.ReadLine();
                Console.WriteLine("Sueldo mes 3:");
                datos[i, 3] = Console.ReadLine();
                Console.Clear();
            }

            return datos;
        }

        private static int[] CalcularAcumulados(string[,] datos)
        {
            int[] resultado = new int[datos.GetLength(0)];

            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = int.Parse(datos[i, 1]) + int.Parse(datos[i, 2]) + int.Parse(datos[i, 3]);
            }

            return resultado;
        }

        private static int CalcularTotal(int[] datos)
        {
            int suma = 0;

            for (int i = 0; i < datos.Length; i++)
            {
                suma += datos[i];
            }

            return suma;
        }

        private static int CalcularPosicionMayor(int[] datos)
        {
            int mayor = 0;

            for (int i = 0; i < datos.Length; i++)
            {
                if (i == 0 || datos[i] > mayor)
                    mayor = i;
            }

            return mayor;
        }

        private static void MostrarMatriz(string[,] datos)
        {
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    Console.Write($"{datos[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }

        private static void MostrarArray(int[] listado)
        {
            for (int i = 0; i < listado.Length; i++)
            {
                Console.Write($"{listado[i]}\t");
            }
            Console.WriteLine("\n");
        }
    }
}