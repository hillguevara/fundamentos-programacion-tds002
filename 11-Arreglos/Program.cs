double[] notas = new double[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Escribe la nota {i + 1}:");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}
double suma = 0;
double mayor = notas[0];
double menor = notas[0];
for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
    if (notas[i] > mayor) mayor = notas[i];
    if (notas[i] < menor) menor = notas[i];
}
double promedio = suma / notas.Length;
int contadorSobrePromedio = 0;
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] > promedio)
    {
        contadorSobrePromedio++;
    }
}
Console.WriteLine($"Promedio: {promedio:F2}");
Console.WriteLine($"Mayor: {mayor}");
Console.WriteLine($"Menor: {menor}");
Console.WriteLine($"Notas sobre el promedio: {contadorSobrePromedio}");
Console.WriteLine("\n--- Ordenamiento burbuja ---");
int[] numeros = { 8, 3, 9, 1, 5, 2, 7 };
Console.WriteLine("Antes de ordenar:");
Console.WriteLine(string.Join(", ", numeros));
for (int i = 0; i < numeros.Length - 1; i++)
{
    for (int j = 0; j < numeros.Length - 1 - i; j++)
    {
        if (numeros[j] > numeros[j + 1])
        {
            int temp = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = temp;
        }
    }
}
Console.WriteLine("Después de ordenar (burbuja):");
Console.WriteLine(string.Join(", ", numeros));
int[] numeros2 = { 8, 3, 9, 1, 5, 2, 7 };
Array.Sort(numeros2);
Console.WriteLine("Con Array.Sort:");
Console.WriteLine(string.Join(", ", numeros2));