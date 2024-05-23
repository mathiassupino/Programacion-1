// Escribe un programa que genere un número aleatorio entre 1 y 10, luego solicita al usuario
// que adivine el número. El programa debe seguir solicitando al usuario que ingrese un
// número hasta que adivine correctamente. El programa debe mostrar cuántos intentos le
// tomó al usuario adivinar el número.

int resultado, intento = -1, contador = 0;

resultado = new Random().Next(1, 11);

while (intento != resultado)
{
    contador++;

    Console.WriteLine("Escriba un número:");
    intento = int.Parse(Console.ReadLine());
}

Console.WriteLine("¡Adivinaste!");
Console.ReadKey();