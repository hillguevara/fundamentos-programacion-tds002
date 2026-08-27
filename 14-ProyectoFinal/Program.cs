List<string> nombres = new List<string>();
List<double> precios = new List<double>();
List<int> cantidades = new List<int>();

void AgregarProducto(string nombre, double precio, int cantidad)
{
    nombres.Add(nombre);
    precios.Add(precio);
    cantidades.Add(cantidad);
    Console.WriteLine($"Producto '{nombre}' agregado.");
}

Console.WriteLine("=== La Repostería de Hill ===");
Console.WriteLine("Escribe el nombre del producto:");
string nom = Console.ReadLine();
Console.WriteLine("Escribe el precio:");
double precio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe la cantidad:");
int cant = Convert.ToInt32(Console.ReadLine());
AgregarProducto(nom, precio, cant);