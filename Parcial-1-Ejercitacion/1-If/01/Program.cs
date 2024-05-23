// Escribe un programa que solicite al usuario ingresar un número entero
// e imprima si el número es positivo, negativo o cero.

int num;

Console.WriteLine("Ingrese un número: ");
num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("El número es cero.");
}
else if (num > 0)
{
    Console.WriteLine("El número es positivo.");
}
else
{
    Console.WriteLine("El número es negativo.");
}

Console.ReadKey();