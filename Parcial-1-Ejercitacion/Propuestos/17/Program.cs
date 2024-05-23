using System;

namespace Ej_17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 17) Ingresar 15 resultados de encuentros deportivos entre 2 equipos.
            // El algoritmo deberá procesar la información y mostrar:
            // - Qué equipo ganó más veces y cuantos partidos ganó. Si no hubiese uno, indicarlo.
            // - Cual fue el equipo que más goles hizo y la cantidad. Si no hubiese uno, indicarlo.
            // - Promedio de goles por partido.

            int cantidadPartidos = 15, resultadoE1, resultadoE2, golesE1 = 0, golesE2 = 0,
                promedioGolesPorPartido, triunfosE1 = 0, triunfosE2 = 0;

            for (int i = 0; i < cantidadPartidos; i++)
            {
                Console.WriteLine($"-- PARTIDO {i + 1} ---------------------");
                Console.WriteLine("Goles equipo 1:");
                resultadoE1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Goles equipo 2:");
                resultadoE2 = int.Parse(Console.ReadLine());

                if (resultadoE1 > resultadoE2)
                    triunfosE1++;
                else if (resultadoE2 > resultadoE1)
                    triunfosE2++;

                golesE1 += resultadoE1;
                golesE2 += resultadoE2;

                Console.Clear();
            }

            Console.WriteLine("-- RESULTADOS ------------------");

            if (triunfosE1 > triunfosE2)
                Console.WriteLine($"> Equipo con más triunfos: Equipo 1 ({triunfosE1} partidos ganados)");
            else if (triunfosE2 > triunfosE1)
                Console.WriteLine($"> Equipo con más triunfos: Equipo 2 ({triunfosE2} partidos ganados)");
            else
                Console.WriteLine($"> Ambos equipos tuvieron la misma cantidad de triunfos: {triunfosE1} partidos ganados");

            if (golesE1 > golesE2)
                Console.WriteLine($"> Equipo con más goles realizados: Equipo 1 ({golesE1} goles)");
            else if (golesE2 > golesE1)
                Console.WriteLine($"> Equipo con más goles realizados: Equipo 2 ({golesE1} goles)");
            else
                Console.WriteLine($"> Ambos equipos tuvieron la misma cantidad de goles realizados: {golesE1} goles");

            promedioGolesPorPartido = (golesE1 + golesE2) / cantidadPartidos;

            Console.WriteLine($"> Cantidad de goles por partido: {promedioGolesPorPartido} goles");

            Console.ReadKey();
        }
    }
}