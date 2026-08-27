Console.WriteLine("Escribe tu nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("Escribe tu edad:");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe tu estatura:");
double estatura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe la inicial de tu apellido:");
char inicial = Console.ReadLine()[0];

Console.WriteLine("¿Eres estudiante activo? Escribe s o n:");
string respuesta = Console.ReadLine();
bool activo = respuesta == "s";

float promedio = 8.5f;
Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Estatura: {estatura}, Inicial: {inicial}, Estudiante activo: {activo}, Promedio: {promedio}");

Console.WriteLine("=== Operaciones con dos números ===");

Console.Write("Ingresa el primer número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

int resultadoSuma = numero1 + numero2;
int resultadoResta = numero1 - numero2;
int resultadoMultiplicacion = numero1 * numero2;

Console.WriteLine("\n--- Resultados matemáticos ---");
Console.WriteLine($"Suma: {resultadoSuma}");
Console.WriteLine($"Resta: {resultadoResta}");
Console.WriteLine($"Multiplicación: {resultadoMultiplicacion}");

if (numero2 != 0)
{
    Console.WriteLine($"Cociente entero: {numero1 / numero2}");
    Console.WriteLine($"Cociente decimal: {(double)numero1 / numero2}");
    Console.WriteLine($"Residuo: {numero1 % numero2}");
}
else
{
    Console.WriteLine("No es posible dividir entre cero.");
}

Console.WriteLine("\n--- Comparaciones ---");
Console.WriteLine($"¿El primer número es mayor? {numero1 > numero2}");
Console.WriteLine($"¿Los números son iguales? {numero1 == numero2}");
Console.WriteLine($"¿Los números son diferentes? {numero1 != numero2}");

bool losDosImpares = (numero1 % 2 != 0) && (numero2 % 2 != 0);
bool existePar = (numero1 % 2 == 0) || (numero2 % 2 == 0);

Console.WriteLine("\n--- Operadores lógicos ---");
Console.WriteLine($"¿Ambos son impares? {losDosImpares}");
Console.WriteLine($"¿Al menos uno es par? {existePar}");

Console.WriteLine("\n--- Orden de las operaciones ---");

int ejemploA = 6 + 4 * 3;
int ejemploB = (6 + 4) * 3;
double ejemploC = 15 / 4.0;
int ejemploD = 15 % 4;

Console.WriteLine($"6 + 4 * 3 = {ejemploA}");
Console.WriteLine($"(6 + 4) * 3 = {ejemploB}");
Console.WriteLine($"15 / 4.0 = {ejemploC}");
Console.WriteLine($"15 % 4 = {ejemploD}");

// 6 + 4 * 3 = 18 porque la multiplicación se evalúa antes que la suma
// (6 + 4) * 3 = 30 porque el paréntesis fuerza a sumar primero
// 15 / 4.0 = 3.75 porque al dividir con un decimal el resultado es real, no truncado
// 15 % 4 = 3 porque el módulo devuelve el residuo de la división entera