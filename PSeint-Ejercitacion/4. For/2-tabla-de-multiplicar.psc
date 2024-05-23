// Escribe un programa que solicite al usuario un número entero y luego imprima la tabla de
// multiplicar de ese número del 1 al 10

Proceso tablaDeMultiplicar
	Definir num, i, resultado Como Entero;
	
	Escribir "Escribir la tabla que desea conocer";
	Leer num;
	
	Para i = 1 Hasta 10 Con Paso 1 Hacer
		resultado = i * num;
		Escribir num, " x ", i, " = ", resultado;
	FinPara
FinProceso
