using System;
using System.Collections.Generic;

class Program
{
    class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }

    static List<Producto> inventario = new List<Producto>();

    static void Main()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("\n=== La Repostería de Hill ===");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Ver inventario");
            Console.WriteLine("3. Vender producto");
            Console.WriteLine("4. Reporte de inventario bajo (< 5 unidades)");
            Console.WriteLine("5. Valor total del inventario");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    VerInventario();
                    break;
                case 3:
                    VenderProducto();
                    break;
                case 4:
                    ReporteInventarioBajo();
                    break;
                case 5:
                    CalcularValorTotal();
                    break;
                case 6:
                    Console.WriteLine("¡Gracias por usar el sistema!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 6);
    }

    static void AgregarProducto()
    {
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Precio: ");
        decimal.TryParse(Console.ReadLine(), out decimal precio);
        Console.Write("Cantidad: ");
        int.TryParse(Console.ReadLine(), out int cantidad);

        inventario.Add(new Producto { Nombre = nombre, Precio = precio, Cantidad = cantidad });
        Console.WriteLine($"Producto '{nombre}' agregado correctamente.");
    }

    static void VerInventario()
    {
        Console.WriteLine("\n--- Inventario ---");
        if (inventario.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }
        foreach (var p in inventario)
        {
            Console.WriteLine($"Producto: {p.Nombre} | Precio: RD${p.Precio} | Cantidad: {p.Cantidad}");
        }
    }

    static void VenderProducto()
    {
        Console.Write("Nombre del producto a vender: ");
        string nombre = Console.ReadLine();
        Producto p = inventario.Find(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

        if (p != null)
        {
            Console.Write("Cantidad a vender: ");
            int.TryParse(Console.ReadLine(), out int cant);
            if (cant <= p.Cantidad)
            {
                p.Cantidad -= cant;
                Console.WriteLine($"Venta realizada. Nuevo stock de {p.Nombre}: {p.Cantidad}");
            }
            else
            {
                Console.WriteLine("Stock insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void ReporteInventarioBajo()
    {
        Console.WriteLine("\n--- Productos con Stock Bajo (< 5) ---");
        var bajoStock = inventario.FindAll(p => p.Cantidad < 5);
        if (bajoStock.Count == 0)
        {
            Console.WriteLine("No hay productos con stock crítico.");
            return;
        }
        foreach (var p in bajoStock)
        {
            Console.WriteLine($"¡Alerta! {p.Nombre} solo tiene {p.Cantidad} unidades.");
        }
    }

    static void CalcularValorTotal()
    {
        decimal total = 0;
        foreach (var p in inventario)
        {
            total += p.Precio * p.Cantidad;
        }
        Console.WriteLine($"\nEl valor total del inventario es: RD${total}");
    }
}
