List<string> nombres = new List<string>();
List<double> precios = new List<double>();
List<int> cantidades = new List<int>();

int opcion;
do
{
    Console.WriteLine("\n=== La Repostería de Hill ===");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Ver inventario");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Elige una opción:");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escribe el nombre del producto:");
            string nom = Console.ReadLine();
            Console.WriteLine("Escribe el precio:");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la cantidad:");
            int cant = Convert.ToInt32(Console.ReadLine());
            AgregarProducto(nom, precio, cant);
            break;

        case 2:
            if (nombres.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
            }
            else
            {
                Console.WriteLine("\n--- Inventario Actual ---");
                for (int i = 0; i < nombres.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]} - Precio: RD${precios[i]:F2} | Stock: {cantidades[i]} unidades");
                }
            }
            break;

        case 3:
            Console.WriteLine("Nombre del producto a vender:");
            string productoVender = Console.ReadLine();
            int indice = nombres.IndexOf(productoVender);
            if (indice == -1)
            {
                Console.WriteLine("Producto no encontrado.");
            }
            else
            {
                Console.WriteLine($"Stock actual: {cantidades[indice]}. ¿Cuánto deseas vender?");
                int cantVender = Convert.ToInt32(Console.ReadLine());
                if (cantVender <= cantidades[indice])
                {
                    cantidades[indice] -= cantVender;
                    Console.WriteLine($"Venta realizada. Nuevo stock de {nombres[indice]}: {cantidades[indice]}");
                }
                else
                {
                    Console.WriteLine("Error: Stock insuficiente para realizar la venta.");
                }
            }
            break;

        case 4:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;
    }
} while (opcion != 4);

void AgregarProducto(string nombre, double precio, int cantidad)
{
    nombres.Add(nombre);
    precios.Add(precio);
    cantidades.Add(cantidad);
    Console.WriteLine($"Producto '{nombre}' agregado.");
}