// Escribe un programa que genere un n�mero aleatorio entre 1 y 10, luego solicita al usuario
// que adivine el n�mero. El programa debe seguir solicitando al usuario que ingrese un
// n�mero hasta que adivine correctamente. El programa debe mostrar cu�ntos intentos le
// tom� al usuario adivinar el n�mero.

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
