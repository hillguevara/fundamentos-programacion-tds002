Console.WriteLine("Escribe un número:");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.WriteLine("\n--- break y continue ---");
for (int i = 1; i <= 50; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    if (i % 7 == 0 && i > 30)
    {
        break;
    }
    Console.WriteLine(i);
}
