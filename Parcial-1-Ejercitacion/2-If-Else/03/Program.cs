// Escribe un programa que solicite al usuario ingresar un año y determine e imprima si el año
// ingresado es bisiesto o no. Un año es bisiesto si es divisible entre 4 pero no entre 100, o si
// es divisible entre 400.

int anio;

Console.WriteLine("Escriba un año:");
anio = int.Parse(Console.ReadLine());

if ((anio % 400 == 0) || ((anio % 100 != 0) && (anio % 4 == 0)))
    Console.WriteLine("Es año bisiesto");
else
    Console.WriteLine("No es año bisiesto");