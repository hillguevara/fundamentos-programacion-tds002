List<string> nombres = new List<string>();
List<double> notas = new List<double>();

int opcion;
do
{
    Console.WriteLine("\n--- Registro de Notas ---");
    Console.WriteLine("1. Agregar estudiante");
    Console.WriteLine("2. Ver promedio del grupo");
    Console.WriteLine("3. Ver lista completa");
    Console.WriteLine("4. Salir");
    opcion = LeerEntero("Elige una opción:");

    switch (opcion)
    {
        case 1:
            AgregarEstudiante(nombres, notas);
            break;
        case 2:
            VerPromedio(notas);
            break;
        case 3:
            VerLista(nombres, notas);
            break;
        case 4:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
} while (opcion != 4);

int LeerEntero(string mensaje)
{
    int valor;
    bool esValido;
    do
    {
        Console.WriteLine(mensaje);
        esValido = int.TryParse(Console.ReadLine(), out valor);
        if (!esValido) Console.WriteLine("Número inválido, intenta de nuevo.");
    } while (!esValido);
    return valor;
}

void AgregarEstudiante(List<string> nombres, List<double> notas)
{
    Console.WriteLine("Nombre del estudiante:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Nota del estudiante:");
    double nota = Convert.ToDouble(Console.ReadLine());
    nombres.Add(nombre);
    notas.Add(nota);
    Console.WriteLine("Estudiante agregado.");
}

void VerPromedio(List<double> notas)
{
    if (notas.Count == 0)
    {
        Console.WriteLine("No hay notas registradas.");
        return;
    }

    double suma = 0;
    foreach (double nota in notas)
    {
        suma += nota;
    }

    double promedio = suma / notas.Count;
    Console.WriteLine($"Promedio del grupo: {promedio:F2}");
}

void VerLista(List<string> nombres, List<double> notas)
{
    if (nombres.Count == 0)
    {
        Console.WriteLine("No hay estudiantes registrados.");
        return;
    }

    Console.WriteLine("\n--- Lista de Estudiantes ---");
    for (int i = 0; i < nombres.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {nombres[i]} - Nota: {notas[i]:F2}");
    }
}