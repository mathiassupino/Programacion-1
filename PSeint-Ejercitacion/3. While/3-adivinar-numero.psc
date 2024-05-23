// Escribe un programa que genere un número aleatorio entre 1 y 10, luego solicita al usuario
// que adivine el número. El programa debe seguir solicitando al usuario que ingrese un
// número hasta que adivine correctamente. El programa debe mostrar cuántos intentos le
// tomó al usuario adivinar el número.

Proceso adivinarNumero
	Definir resultado, prueba, intentos Como Entero;
	
	resultado = azar(10) + 1;
	prueba = 11;
	intentos = 0;
	
	Mientras prueba <> resultado Hacer
		Escribir 'Escriba un numero del 1 al 10';
		Leer prueba;
		intentos = intentos + 1;
	FinMientras
	
	Escribir 'Adivinaste el numero en ', intentos, ' intentos';
FinProceso
