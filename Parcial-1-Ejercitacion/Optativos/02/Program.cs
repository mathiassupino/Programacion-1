using System;

namespace Ej_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Determinar cual es la persona mayor de un grupo de 250 personas,
            // por cada persona se ingresa:
            //   dd(día)
            //   mm(mes)
            //   aa(año de nacimiento)
            // Nota: Suponga que todos los meses son de 30 días y el año es de 360 días.

            int cantidad = 3, personaMayor = 0;
            int diaActual, diaMayor = 0;
            int mesActual, mesMayor = 0;
            int anioActual, anioMayor = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"\n-- PERSONA {i} ---------");

                Console.WriteLine("Día de nacimiento (dd):");
                diaActual = int.Parse(Console.ReadLine());

                Console.WriteLine("Mes de nacimiento (mm):");
                mesActual = int.Parse(Console.ReadLine());

                Console.WriteLine("Año de nacimiento (aa):");
                anioActual = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    personaMayor = i;
                    diaMayor = diaActual;
                    mesMayor = mesActual;
                    anioMayor = anioActual;
                    continue;
                }
                else
                {
                    if (anioActual > anioMayor)
                        continue;

                    if (anioActual == anioMayor)
                    {
                        if (mesActual > mesMayor)
                            continue;

                        if (mesActual == mesMayor)
                        {
                            if (diaActual > diaMayor)
                                continue;

                            if (diaActual < diaMayor)
                            {
                                personaMayor = i;
                                diaMayor = diaActual;
                                mesMayor = mesActual;
                                anioMayor = anioActual;
                                continue;
                            }
                        }
                    }
                    else
                    {
                        personaMayor = i;
                        diaMayor = diaActual;
                        mesMayor = mesActual;
                        anioMayor = anioActual;
                        continue;
                    }
                }
            }

            Console.WriteLine($"\nLa persona {personaMayor} es la mayor. Nació el {diaMayor}/{mesMayor}/{anioMayor}");
            Console.ReadKey();
        }
    }
}