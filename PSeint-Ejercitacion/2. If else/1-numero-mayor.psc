Proceso numeroMayor
	Definir num1, num2 Como Entero;
	
	num1 = 0;
	num2 = 0;
	
	Escribir 'Escribir el primer numero';
	Leer num1;
	Escribir 'Escribir el segundo numero';
	Leer num2;
	
	Si num1>num2 Entonces
		Escribir 'El primer número es mayor';
	SiNo
		Si num1 < num2 Entonces
			Escribir 'El segundo número es mayor';
		SiNo
			Escribir 'Los numeros son iguales';
		FinSi
	FinSi
FinProceso
