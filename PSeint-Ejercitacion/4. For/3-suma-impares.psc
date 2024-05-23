// Escribe un programa que calcule la suma de todos los números impares del 1 al 100

Proceso sumaImpares
	Definir suma, i Como Entero;
	
	suma = 0;
	
	Para i = 1 Hasta 100 Con Paso 1 Hacer
		Si i % 2 <> 0 Entonces
			suma = suma + i;
		FinSi
	FinPara
	
	Escribir "La suma total es ", suma;
FinProceso
