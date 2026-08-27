Console.WriteLine("--- FACTURA DE COLMADO ---");
Console.WriteLine("Nombre del cliente:");
string cliente = Console.ReadLine();

Console.WriteLine("Producto 1 - Nombre:");
string prod1 = Console.ReadLine();
Console.WriteLine("Producto 1 - Precio:");
double precio1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Producto 1 - Cantidad:");
int cant1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Producto 2 - Nombre:");
string prod2 = Console.ReadLine();
Console.WriteLine("Producto 2 - Precio:");
double precio2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Producto 2 - Cantidad:");
int cant2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Producto 3 - Nombre:");
string prod3 = Console.ReadLine();
Console.WriteLine("Producto 3 - Precio:");
double precio3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Producto 3 - Cantidad:");
int cant3 = Convert.ToInt32(Console.ReadLine());

double subtotal1 = precio1 * cant1;
double subtotal2 = precio2 * cant2;
double subtotal3 = precio3 * cant3;

double subtotalGeneral = subtotal1 + subtotal2 + subtotal3;
double itbis = subtotalGeneral * 0.18;
double totalFactura = subtotalGeneral + itbis;

Console.WriteLine($"\nCliente: {cliente}");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"{"Producto",-15} {"Cant.",-8} {"Precio",-10} {"Subtotal",-10}");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"{prod1,-15} {cant1,-8} {precio1,10:C} {subtotal1,10:C}");
Console.WriteLine($"{prod2,-15} {cant2,-8} {precio2,10:C} {subtotal2,10:C}");
Console.WriteLine($"{prod3,-15} {cant3,-8} {precio3,10:C} {subtotal3,10:C}");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"{"Subtotal:",-35} {subtotalGeneral,10:C}");
Console.WriteLine($"{"ITBIS (18%):",-35} {itbis,10:C}");
Console.WriteLine($"{"Total a pagar:",-35} {totalFactura,10:C}");

Console.WriteLine("\n--- NÓMINA SIMPLE ---");
Console.WriteLine("Escribe las horas trabajadas:");
double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe la tarifa por hora:");
double tarifaHora = Convert.ToDouble(Console.ReadLine());

double salarioBruto = horasTrabajadas * tarifaHora;
double afp = salarioBruto * 0.0287;
double sfs = salarioBruto * 0.0304;
double salarioNeto = salarioBruto - (afp + sfs);

Console.WriteLine($"\nSalario Bruto:   {salarioBruto:C}");
Console.WriteLine($"Descuento AFP:   {afp:C}");
Console.WriteLine($"Descuento SFS:   {sfs:C}");
Console.WriteLine($"Salario Neto:    {salarioNeto:C}");

Console.WriteLine("\n--- RELOJ DE SEGUNDOS ---");
Console.WriteLine("Escribe la cantidad total de segundos:");
int totalSegundos = Convert.ToInt32(Console.ReadLine());

int horas = totalSegundos / 3600;
int restoSegundos = totalSegundos % 3600;
int minutos = restoSegundos / 60;
int segundos = restoSegundos % 60;

Console.WriteLine($"Tiempo equivalente: {horas:D2}h {minutos:D2}m {segundos:D2}s");
