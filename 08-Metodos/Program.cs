ImprimirTitulo("BIBLIOTECA MATEMÁTICA");

Console.WriteLine("Escribe un número para factorial:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial: {Factorial(n)}");

Console.WriteLine("\nEscribe un número para saber si es primo:");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"¿Es primo? {EsPrimo(p)}");

Console.WriteLine("\nEscribe el primer número para el MCD:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escribe el segundo número para el MCD:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"MCD: {Mcd(a, b)}");

Console.WriteLine("\nEscribe la base para la potencia:");
double baseNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe el exponente:");
int exp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Potencia: {Potencia(baseNum, exp)}");

int Factorial(int num)
{
    if (num <= 1) return 1;
    return num * Factorial(num - 1);
}

bool EsPrimo(int num)
{
    if (num < 2) return false;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int Mcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

double Potencia(double baseNum, int exponente)
{
    double resultado = 1;
    for (int i = 0; i < exponente; i++)
    {
        resultado *= baseNum;
    }
    return resultado;
}

void ImprimirLinea(char c, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(c);
    }
    Console.WriteLine();
}

void ImprimirTitulo(string t)
{
    ImprimirLinea('=', 20);
    Console.WriteLine(t);
    ImprimirLinea('=', 20);
}
