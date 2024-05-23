// Escribe un programa que solicite al usuario ingresar la calificación numérica de un
// estudiante y determine e imprima su calificación en letra según la siguiente escala: 90 - 100
// (A), 80 - 89(B), 70 - 79(C), 60 - 69(D), por debajo de 60 (F).

int calificacion;
string letra;

Console.WriteLine("Ingrese la calificación:");
calificacion = int.Parse(Console.ReadLine());

if (calificacion >= 90 && calificacion <= 100)
    letra = "A";
else if (calificacion >= 80 && calificacion <= 89)
    letra = "B";
else if (calificacion >= 70 && calificacion <= 79)
    letra = "C";
else if (calificacion >= 60 && calificacion <= 69)
    letra = "D";
else
    letra = "F";

Console.WriteLine($"\nLa calificación del alumno es {letra}");
Console.ReadKey();