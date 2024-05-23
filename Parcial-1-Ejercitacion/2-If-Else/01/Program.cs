// Escribe un programa que solicite al usuario ingresar dos números enteros
// y luego determine e imprima cuál de los dos números es el mayor.

int num1, num2;

Console.WriteLine("Escribe el primer número:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe el segundo número:");
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine("\nEl primer número es mayor.");
else
    Console.WriteLine("\nEl segundo número es mayor.");

Console.ReadKey();