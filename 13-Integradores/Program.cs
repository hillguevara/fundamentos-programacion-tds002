Console.WriteLine("--- Analizador de Texto ---");
Console.WriteLine("Escribe una frase:");
string frase = Console.ReadLine();

Console.WriteLine($"Cantidad de palabras: {ContarPalabras(frase)}");
Console.WriteLine($"Cantidad de vocales: {ContarVocales(frase)}");
Console.WriteLine($"Cantidad de consonantes: {ContarConsonantes(frase)}");
Console.WriteLine($"Palabra más larga: {PalabraMasLarga(frase)}");

Console.WriteLine("\n--- Registro de Estudiantes ---");
List<string> nombresEst = new List<string>();
List<double> notasEst = new List<double>();
int opcionEst;
do
{
    Console.WriteLine("\n1. Agregar estudiante");
    Console.WriteLine("2. Buscar por nombre");
    Console.WriteLine("3. Ver promedio del grupo");
    Console.WriteLine("4. Mostrar aprobados");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elige una opción:");
    opcionEst = Convert.ToInt32(Console.ReadLine());

    switch (opcionEst)
    {
        case 1:
            Console.WriteLine("Nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Nota:");
            double nota = Convert.ToDouble(Console.ReadLine());
            nombresEst.Add(nom);
            notasEst.Add(nota);
            break;
        case 2:
            Console.WriteLine("Nombre a buscar:");
            string nombreBuscado = Console.ReadLine();
            int indice = nombresEst.IndexOf(nombreBuscado);
            if (indice == -1)
            {
                Console.WriteLine("No encontrado.");
            }
            else
            {
                Console.WriteLine($"Nota de {nombreBuscado}: {notasEst[indice]}");
            }
            break;
        case 3:
            if (notasEst.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
            }
            else
            {
                double sumaNotas = 0;
                foreach (double n in notasEst)
                {
                    sumaNotas += n;
                }
                Console.WriteLine($"Promedio del grupo: {(sumaNotas / notasEst.Count):F2}");
            }
            break;
        case 4:
            Console.WriteLine("Estudiantes aprobados:");
            for (int i = 0; i < nombresEst.Count; i++)
            {
                if (notasEst[i] >= 70)
                {
                    Console.WriteLine(nombresEst[i]);
                }
            }
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
    }
} while (opcionEst != 5);

int ContarPalabras(string texto)
{
    string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return palabras.Length;
}

int ContarVocales(string texto)
{
    string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";
    int contador = 0;
    foreach (char c in texto)
    {
        if (vocales.Contains(c)) contador++;
    }
    return contador;
}

int ContarConsonantes(string texto)
{
    string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";
    int contador = 0;
    foreach (char c in texto)
    {
        if (char.IsLetter(c) && !vocales.Contains(c))
        {
            contador++;
        }
    }
    return contador;
}

string PalabraMasLarga(string texto)
{
    string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string masLarga = "";
    foreach (string p in palabras)
    {
        if (p.Length > masLarga.Length) masLarga = p;
    }
    return masLarga;
}