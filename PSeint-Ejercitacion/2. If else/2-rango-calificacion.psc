Proceso rangoCalificacion
	Definir clasificacion Como Entero;
	Definir nota Como Caracter;
	
	clasificacion = 0;
	nota = '';
	
	Escribir 'Escribir la clasificacion del alumno';
	Leer clasificacion;
	
	Si clasificacion >= 90 Y clasificacion <= 100 Entonces
		nota = 'A';
	FinSi
	
	Si clasificacion >= 90 Y clasificacion <= 89 Entonces
		nota = 'B';
	FinSi
	
	Si clasificacion >= 70 Y clasificacion <= 79 Entonces
		nota = 'C';
	FinSi
	
	Si clasificacion >= 60 Y clasificacion <= 69 Entonces
		nota = 'D';
	FinSi
	
	Si clasificacion < 60 Entonces
		nota = 'F';
	FinSi
	
	Escribir 'Su nota es ', nota;	
FinProceso
