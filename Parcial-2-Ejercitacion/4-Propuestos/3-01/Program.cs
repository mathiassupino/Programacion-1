using System;

namespace _3_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cantAbuelos = 2, mayorEdad = int.MinValue, menorEdad = int.MaxValue, 
                posicionMayor = 0, posicionMenor = 0, cantMujeresConObra,
                cantEdadesMayoresAlPromedio;
            string nombreMayorEdad = "", nombreMenorEdad = "";
            double promedioEdades, porcentajeSinObra;
            int[] edades = new int[cantAbuelos];
            string[] sexos = new string[cantAbuelos];
            bool[] obrasSociales = new bool[cantAbuelos];

            for (int i = 0; i < cantAbuelos; i++)
            {
                Console.WriteLine("--- NUEVO ABUELO ---------------");
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad:");
                edades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Sexo: (M: masculino / F: femenino)");
                sexos[i] = Console.ReadLine();
                Console.WriteLine("Tiene obra social? (1: si / 2: no)");
                obrasSociales[i] = bool.Parse(Console.ReadLine());

                if (edades[i] > mayorEdad)
                {
                    mayorEdad = edades[i];
                    nombreMayorEdad = nombre;
                    posicionMayor = i;
                }

                if (edades[i] < menorEdad)
                {
                    menorEdad = edades[i];
                    nombreMenorEdad = nombre;
                    posicionMenor = i;
                }

                Console.Clear();
            }

            promedioEdades = CalcularPromedioDeEdades(edades);
            porcentajeSinObra = CalcularPorcentajeSinObraSocial(obrasSociales);
            cantMujeresConObra = CalcularCantidadMujeresConObraSocial(sexos, obrasSociales);
            cantEdadesMayoresAlPromedio = CalcularCantidadEdadesMayoresAlPromedio(edades, promedioEdades);

            Console.WriteLine("--- ABUELO DE MAYOR EDAD -----------------");
            Console.WriteLine($"Nombre: {nombreMayorEdad}");
            Console.WriteLine($"Sexo: {sexos[posicionMayor]}");
            Console.WriteLine($"Edad: {edades[posicionMayor]}");
            Console.WriteLine("--- ABUELO DE MENOR EDAD -----------------");
            Console.WriteLine($"Nombre: {nombreMenorEdad}");
            Console.WriteLine($"Sexo: {sexos[posicionMenor]}");
            Console.WriteLine($"Edad: {edades[posicionMenor]}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Promedio de edad: {promedioEdades}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Sin obra social: {porcentajeSinObra}%");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Mujeres con obra social: {cantMujeresConObra}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Mayores al promedio: {cantEdadesMayoresAlPromedio}");

            Console.ReadKey();
        }

        private static double CalcularPromedioDeEdades(int[] edades)
        {
            double suma = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                suma += edades[i];
            }

            return suma / edades.Length;
        }

        private static double CalcularPorcentajeSinObraSocial(bool[] obrasSociales)
        {
            int cantidadSinObraSocial = 0;

            for (int i = 0; i < obrasSociales.Length; i++)
            {
                if (!obrasSociales[i])
                    cantidadSinObraSocial++;
            }

            return cantidadSinObraSocial * 100d / obrasSociales.Length;
        }

        private static int CalcularCantidadMujeresConObraSocial(string[] sexos, bool[] obrasSociales)
        {
            int resultado = 0;

            for (int i = 0; i < sexos.Length; i++)
            {
                if (sexos[i].ToUpper() == "F" && obrasSociales[i])
                    resultado++;
            }

            return resultado;
        }

        private static int CalcularCantidadEdadesMayoresAlPromedio(int[] edades, double promedio)
        {
            int resultado = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] > promedio)
                    resultado++;
            }

            return resultado;
        }
    }
}