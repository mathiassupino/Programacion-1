using System;

namespace _02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] apellidos = { "supino", "civalero" };
            bool encontrado = false;
            int posicionEncontrado = -1;
            string ingreso;

            Console.WriteLine("Ingrese el apellido buscado:");
            ingreso = Console.ReadLine();

            for (int i = 0; i < apellidos.Length && !encontrado; i++)
            {
                if (ingreso == apellidos[i])
                {
                    encontrado = true;
                    posicionEncontrado = i;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"Apellido encontrado en posición {posicionEncontrado}");
            }
            else
            {
                Console.WriteLine("Apellido no encontrado");
            }

            Console.ReadKey();
        }
    }
}