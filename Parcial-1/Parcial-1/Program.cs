using System;
using System.Reflection;

namespace Parcial_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cantidadMinimaAlumnos = 5, cantidadInicialesAlumnos = 3, cantidadAlumnosCargados = 0,
                cantidadInicialesHombres = 0, cantidadInicialesMujeres = 0,
                cantidadInicialesAprobados = 0, cantidadInicialesDesaprobados = 0,
                sexo, opcion;

            float nota1, nota2, nota3, acumuladorNotas = 0f, promedio, promedioGeneral,
                promedioMayor = 0f, promedioMenor = 0f;

            string nombre, nombreMayorPromedio = "", nombreMenorPromedio = "";

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine($"-- ALUMNO N°{cantidadAlumnosCargados + 1} ---------------------");

                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("\nSexo (1: Masculino / 2: Femenino):");
                sexo = int.Parse(Console.ReadLine());

                while (sexo != 1 && sexo != 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n(!) EL SEXO INGRESADO NO ES VÁLIDO");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Sexo (1: Masculino / 2: Femenino):");
                    sexo = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nNota 1:");
                nota1 = float.Parse(Console.ReadLine());

                while (nota1 < 1 || nota1 > 10)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n(!) LA NOTA SER ENTRE 1 Y 10");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Nota 1:");
                    nota1 = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nNota 2:");
                nota2 = float.Parse(Console.ReadLine());

                while (nota2 < 1 || nota2 > 10)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n(!) LA NOTA SER ENTRE 1 Y 10");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Nota 2:");
                    nota2 = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nNota 3:");
                nota3 = float.Parse(Console.ReadLine());

                while (nota3 < 1 || nota3 > 10)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n(!) LA NOTA SER ENTRE 1 Y 10");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Nota 3:");
                    nota3 = float.Parse(Console.ReadLine());
                }

                acumuladorNotas += (nota1 + nota2 + nota3);

                cantidadAlumnosCargados++;
                promedio = (nota1 + nota2 + nota3) / 3f;

                if (cantidadAlumnosCargados <= cantidadInicialesAlumnos)
                {
                    if (sexo == 1)
                        cantidadInicialesHombres++;
                    else
                        cantidadInicialesMujeres++;

                    if (promedio >= 6)
                        cantidadInicialesAprobados++;
                    else
                        cantidadInicialesDesaprobados++;
                }

                if (cantidadAlumnosCargados == 1)
                {
                    promedioMayor = promedio;
                    promedioMenor = promedio;
                    nombreMayorPromedio = nombre;
                    nombreMenorPromedio = nombre;
                }
                else
                {
                    if (promedio > promedioMayor)
                    {
                        promedioMayor = promedio;
                        nombreMayorPromedio = nombre;
                    }
                    else if (promedio < promedioMenor)
                    {
                        promedioMenor = promedio;
                        nombreMenorPromedio = nombre;
                    }
                }

                if (cantidadAlumnosCargados >= cantidadMinimaAlumnos)
                {
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("¿Desea seguir cargando datos? (0: Salir / 1: Continuar):");
                    opcion = int.Parse(Console.ReadLine());

                    while (opcion != 0 && opcion != 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n(!) LA OPCIÓN INGRESADA NO ES VÁLIDA");

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("¿Desea seguir cargando datos? (0: Salir / 1: Continuar):");
                        opcion = int.Parse(Console.ReadLine());
                    }

                    continuar = opcion == 1;
                }

                Console.Clear();
            }

            promedioGeneral = acumuladorNotas / (cantidadAlumnosCargados * 3);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-- TODOS LOS ALUMNOS -----------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Alumno con mayor promedio: {nombreMayorPromedio}");
            Console.WriteLine($"Mayor promedio: {promedioMayor:0.00}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Alumno con menor promedio: {nombreMenorPromedio}");
            Console.WriteLine($"Menor promedio: {promedioMenor:0.00}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Cantidad de alumnos: {cantidadAlumnosCargados}");
            Console.WriteLine($"Promedio general del curso: {promedioGeneral:0.00}");
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n-- PRIMEROS {cantidadInicialesAlumnos} ALUMNOS ----------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Cantidad de alumnos aprobados: {cantidadInicialesAprobados}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Cantidad de alumnos desaprobados: {cantidadInicialesDesaprobados}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Cantidad de hombres: {cantidadInicialesHombres}");
            Console.WriteLine($"Cantidad de mujeres: {cantidadInicialesMujeres}");

            Console.ReadKey();
        }
    }
}