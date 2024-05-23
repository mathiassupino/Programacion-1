using System;

namespace Simulacro_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float notaMayor = float.MinValue, notaMenor = float.MaxValue;
            float nota, promedio, sumaNotas = 0;

            string alumnoMayor = "", alumnoMenor = "";
            string nombreAlumno;

            int contadorAprobados = 0, contadorDesaprobados = 0, totalAlumnos = 0;

            bool salir = false;

            Console.WriteLine("(!) Ingrese 0 para salir del sistema.");

            while (!salir)
            {
                Console.WriteLine("\n-- NUEVO ALUMNO ------------");
                Console.WriteLine("Nombre:");
                nombreAlumno = Console.ReadLine();

                if (nombreAlumno == "0")
                {
                    salir = true;
                    continue;
                }

                Console.WriteLine("Nota:");
                nota = float.Parse(Console.ReadLine());

                if (nota == 0)
                {
                    salir = true;
                    continue;
                }

                if (nota > notaMayor)
                {
                    notaMayor = nota;
                    alumnoMayor = nombreAlumno;
                }

                if (nota < notaMenor)
                {
                    notaMenor = nota;
                    alumnoMenor = nombreAlumno;
                }

                if (nota >= 6)
                    contadorAprobados++;
                else
                    contadorDesaprobados++;

                sumaNotas += nota;
            }

            totalAlumnos = contadorAprobados + contadorDesaprobados;
            promedio = sumaNotas / totalAlumnos;

            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine($"La nota más alta: {notaMayor}");
            Console.WriteLine($"Alumno: {alumnoMayor}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"La nota más baja: {notaMenor}");
            Console.WriteLine($"Alumno: {alumnoMenor}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Cantidad de aprobados: {contadorAprobados}");
            Console.WriteLine($"Cantidad de desaprobados: {contadorDesaprobados}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Promedio general: {promedio}");
            Console.WriteLine($"Cantidad de alumnos: {totalAlumnos}");
            Console.WriteLine("-------------------------------------------------");

            Console.ReadKey();
        }
    }
}