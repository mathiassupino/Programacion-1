//Escribe un programa que solicite al usuario ingresar un número entero
//e imprima si el número es par o impar.

int num;

Console.WriteLine("Escriba un número:");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}

Console.ReadKey();