Proceso anioBisiesto
	Definir anio Como Entero;
	
	anio = 0;
	
	Escribir 'Escriba el año';
	Leer anio;
	
	Si (anio mod 400 = 0) O ((anio mod 100 <> 0) Y (anio mod 4 == 0)) Entonces
		Escribir 'Es año bisiesto';
	SiNo
		Escribir 'No es año bisiesto';
	FinSi	
FinProceso
