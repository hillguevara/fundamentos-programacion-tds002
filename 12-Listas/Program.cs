Random rnd = new Random();
List<int> numeros = new List<int>();
for (int i = 0; i < 15; i++)
{
    numeros.Add(rnd.Next(1, 101));
}

Console.WriteLine("Lista original: " + string.Join(", ", numeros));

List<int> pares = new List<int>();
List<int> mayoresA50 = new List<int>();

foreach (int n in numeros)
{
    if (n % 2 == 0)
    {
        pares.Add(n);
    }

    if (n > 50)
    {
        mayoresA50.Add(n);
    }
}

Console.WriteLine($"Cantidad de pares: {pares.Count}");
Console.WriteLine($"Cantidad mayores a 50: {mayoresA50.Count}");

Console.WriteLine("\n--- Lista de Tareas ---");
List<string> tareas = new List<string>();
int opcion;
do
{
    Console.WriteLine("\n1. Agregar tarea");
    Console.WriteLine("2. Eliminar tarea");
    Console.WriteLine("3. Marcar como hecha");
    Console.WriteLine("4. Listar tareas");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elige una opción:");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escribe la tarea:");
            string nuevaTarea = Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada.");
            break;
        case 2:
            Console.WriteLine("Número de tarea a eliminar:");
            int numEliminar = Convert.ToInt32(Console.ReadLine());
            if (numEliminar > 0 && numEliminar <= tareas.Count)
            {
                tareas.RemoveAt(numEliminar - 1);
                Console.WriteLine("Tarea eliminada.");
            }
            else
            {
                Console.WriteLine("Número de tarea inválido.");
            }
            break;
        case 3:
            Console.WriteLine("Número de tarea a marcar como hecha:");
            int numMarcar = Convert.ToInt32(Console.ReadLine());
            if (numMarcar > 0 && numMarcar <= tareas.Count)
            {
                tareas[numMarcar - 1] = "[x] " + tareas[numMarcar - 1];
                Console.WriteLine("Tarea marcada como hecha.");
            }
            else
            {
                Console.WriteLine("Número de tarea inválido.");
            }
            break;
        case 4:
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
} while (opcion != 5);