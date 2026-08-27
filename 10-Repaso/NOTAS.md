WHILE vs FOR vs DO-WHILE



while:

Lo usaría cuando no sé exactamente cuántas veces necesito repetir algo. La condición se revisa antes de ejecutar el código. Por ejemplo, mientras un número sea menor o igual a 5, lo voy mostrando.



Ejemplo:

int numero = 1;



while (numero <= 5)

{

Console.WriteLine(numero);

numero++;

}



for:

Lo usaría cuando ya sé cuántas veces quiero repetir algo. Es común cuando necesito contar desde un número hasta otro.



Ejemplo:

for (int i = 1; i <= 5; i++)

{

Console.WriteLine(i);

}



do-while:

Lo usaría cuando quiero que el código se ejecute por lo menos una vez, aunque la condición no se cumpla. La condición se revisa después de ejecutar el código.



Ejemplo:

int numero;



do

{

Console.Write("Escribe un número mayor que 0: ");

numero = int.Parse(Console.ReadLine());

}

while (numero <= 0);



En resumen:



\* for: cuando sé cuántas veces quiero repetir.

\* while: cuando depende de una condición y no sé cuántas veces se repetirá.

\* do-while: cuando necesito que se ejecute al menos una vez.



