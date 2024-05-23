// Escribe un programa que solicite al usuario ingresar un número del 1 al 7
// representando un día de la semana, e imprima el nombre del día correspondiente.

int num;

Console.WriteLine("Ingrese un número: ");
num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Lunes");
        break;

    case 2:
        Console.WriteLine("Martes");
        break;

    case 3:
        Console.WriteLine("Miércoles");
        break;

    case 4:
        Console.WriteLine("Jueves");
        break;

    case 5:
        Console.WriteLine("Viernes");
        break;

    case 6:
        Console.WriteLine("Sábado");
        break;

    case 7:
        Console.WriteLine("Domingo");
        break;

    default:
        Console.WriteLine("No corresponde a ningún día de la semana");
        break;
}

Console.ReadKey();