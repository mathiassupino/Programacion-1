// Escribe un programa que solicite al usuario números enteros positivos y calcule la suma de
// todos los números ingresados hasta que el usuario ingrese un número negativo.

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
