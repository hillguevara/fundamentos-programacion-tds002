Console.WriteLine("Escribe tu nota (0-100):");
int nota = Convert.ToInt32(Console.ReadLine());

if (nota < 0 || nota > 100)
{
    Console.WriteLine("Nota fuera de rango");
}
else if (nota >= 90)
{
    Console.WriteLine("Letra: A");
    Console.WriteLine("Estado: Aprobado");
}
else if (nota >= 80)
{
    Console.WriteLine("Letra: B");
    Console.WriteLine("Estado: Aprobado");
}
else if (nota >= 70)
{
    Console.WriteLine("Letra: C");
    Console.WriteLine("Estado: Aprobado");
}
else
{
    Console.WriteLine("Letra: F");
    Console.WriteLine("Estado: No aprobado");
}

Console.WriteLine("\n--- Menú de cafetería ---");
Console.WriteLine("1. Café - 60");
Console.WriteLine("2. Té - 50");
Console.WriteLine("3. Sandwich - 150");
Console.WriteLine("4. Croissant - 100");
Console.WriteLine("5. Jugo - 80");
Console.WriteLine("Elige una opción:");
int opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cantidad:");
int cantidad = Convert.ToInt32(Console.ReadLine());

double precioUnitario;
switch (opcion)
{
    case 1:
        precioUnitario = 60;
        break;
    case 2:
        precioUnitario = 50;
        break;
    case 3:
        precioUnitario = 150;
        break;
    case 4:
        precioUnitario = 100;
        break;
    case 5:
        precioUnitario = 80;
        break;
    default:
        precioUnitario = 0;
        Console.WriteLine("Opción inválida");
        break;
}

if (precioUnitario > 0)
{
    double total = precioUnitario * cantidad;
    Console.WriteLine($"Total a pagar: {total:C}");
}

Console.WriteLine("\n--- Triángulo ---");
Console.WriteLine("Escribe el lado A:");
double ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe el lado B:");
double ladoB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe el lado C:");
double ladoC = Convert.ToDouble(Console.ReadLine());

bool esTriangulo = (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA);

if (!esTriangulo)
{
    Console.WriteLine("No forma un triángulo");
}
else
{
    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("Tipo de triángulo: Equilátero");
    }
    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
        Console.WriteLine("Tipo de triángulo: Isósceles");
    }
    else
    {
        Console.WriteLine("Tipo de triángulo: Escaleno");
    }
}