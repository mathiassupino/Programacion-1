// Escribe un programa que solicite al usuario n�meros enteros positivos y calcule la suma de
// todos los n�meros ingresados hasta que el usuario ingrese un n�mero negativo.

Proceso buclePositivos
	Definir num, suma Como Entero;
	
	num = 0;
	suma = 0;
	
	Escribir 'Escribir un numero';
	Leer num;
	
	Mientras num > 0 Hacer
		suma = suma + num;
		
		Escribir 'Escribir un numero';
		Leer num;
	FinMientras
	
	Escribir 'La suma total da ', suma;	
FinProceso
