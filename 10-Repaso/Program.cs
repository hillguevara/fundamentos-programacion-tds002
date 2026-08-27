int pinCorrecto = 1234;
bool accesoConcedido = false;

for (int intento = 1; intento <= 3; intento++)
{
    int pinIngresado = LeerEntero("Escribe tu PIN:");
    if (pinIngresado == pinCorrecto)
    {
        accesoConcedido = true;
        break;
    }
    Console.WriteLine($"PIN incorrecto. Intentos restantes: {3 - intento}");
}

if (!accesoConcedido)
{
    Console.WriteLine("Acceso bloqueado.");
    return;
}

double saldo = 10000;
int opcion;

do
{
    Console.WriteLine("\n--- CAJERO AUTOMÁTICO ---");
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Depositar dinero");
    Console.WriteLine("3. Retirar dinero");
    Console.WriteLine("4. Salir");
    opcion = LeerEntero("Elige una opción:");

    switch (opcion)
    {
        case 1:
            ConsultarSaldo(saldo);
            break;
        case 2:
            saldo = Depositar(saldo);
            break;
        case 3:
            saldo = Retirar(saldo);
            break;
        case 4:
            Console.WriteLine("Gracias por utilizar nuestros servicios.");
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (opcion != 4);

void ConsultarSaldo(double saldoActual)
{
    Console.WriteLine($"Tu saldo actual es: {saldoActual:C}");
}

double Depositar(double saldoActual)
{
    int monto = LeerEntero("Ingresa el monto a depositar (múltiplos de 100):");
    if (monto <= 0)
    {
        Console.WriteLine("El monto debe ser mayor a cero.");
    }
    else if (monto % 100 != 0)
    {
        Console.WriteLine("El monto debe ser un múltiplo de 100.");
    }
    else
    {
        saldoActual += monto;
        Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldoActual:C}");
    }
    return saldoActual;
}

double Retirar(double saldoActual)
{
    int monto = LeerEntero("Ingresa el monto a retirar (múltiplos de 100):");
    if (monto <= 0)
    {
        Console.WriteLine("El monto debe ser mayor a cero.");
    }
    else if (monto % 100 != 0)
    {
        Console.WriteLine("El monto debe ser un múltiplo de 100.");
    }
    else if (monto > saldoActual)
    {
        Console.WriteLine("Fondos insuficientes para realizar esta transacción.");
    }
    else
    {
        saldoActual -= monto;
        Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldoActual:C}");
    }
    return saldoActual;
}

int LeerEntero(string mensaje)
{
    int valor;
    bool esValido;
    do
    {
        Console.WriteLine(mensaje);
        esValido = int.TryParse(Console.ReadLine(), out valor);
        if (!esValido) Console.WriteLine("Número inválido.");
    } while (!esValido);
    return valor;
}
