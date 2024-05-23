// Escribe un programa que solicite al usuario números enteros positivos y calcule la suma de
// todos los números ingresados hasta que el usuario ingrese un número negativo.

int num = 0, suma = 0;

while (num >= 0)
{
    suma += num;

    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());
}

Console.WriteLine($"\nLa suma de los números ingresados es {suma}");

Console.ReadKey();