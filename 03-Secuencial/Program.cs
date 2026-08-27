Console.WriteLine("Escribe la temperatura en Celsius:");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
double kelvin = celsius + 273.15;
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
Console.WriteLine($"Kelvin: {kelvin:F2}");

Console.WriteLine("Escribe el radio del círculo:");
double radio = Convert.ToDouble(Console.ReadLine());
double areaCirculo = Math.PI * Math.Pow(radio, 2);
double perimetroCirculo = 2 * Math.PI * radio;
Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
Console.WriteLine($"Perímetro del círculo: {perimetroCirculo:F2}");

Console.WriteLine("Escribe la base del rectángulo:");
double baseRect = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe la altura del rectángulo:");
double alturaRect = Convert.ToDouble(Console.ReadLine());
double areaRect = baseRect * alturaRect;
double perimetroRect = 2 * (baseRect + alturaRect);
Console.WriteLine($"Área del rectángulo: {areaRect:F2}");
Console.WriteLine($"Perímetro del rectángulo: {perimetroRect:F2}");

Console.WriteLine("Escribe el monto en pesos dominicanos (RD$):");
double montoRD = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe la tasa de cambio RD$ a USD (ej. 60):");
double tasaUSD = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe la tasa de cambio RD$ a EUR (ej. 65):");
double tasaEUR = Convert.ToDouble(Console.ReadLine());

double montoUSD = montoRD / tasaUSD;
double montoEUR = montoRD / tasaEUR;
Console.WriteLine($"Equivalente en dólares: ${montoUSD:F2}");
Console.WriteLine($"Equivalente en euros: €{montoEUR:F2}");

Console.WriteLine("Escribe tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Escribe tu apellido:");
string apellido = Console.ReadLine();

string nombreCompleto = nombre + " " + apellido;
string nombreMayus = nombreCompleto.ToUpper();
int cantidadLetras = nombreCompleto.Length;
string iniciales = nombre.Substring(0, 1) + apellido.Substring(0, 1);

Console.WriteLine($"Nombre completo en mayúsculas: {nombreMayus}");
Console.WriteLine($"Cantidad de letras: {cantidadLetras}");
Console.WriteLine($"Iniciales: {iniciales}");
