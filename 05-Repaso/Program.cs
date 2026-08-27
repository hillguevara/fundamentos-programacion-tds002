Console.WriteLine("Escribe la distancia del viaje en kilómetros:");
double distancia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe el consumo del vehículo (km por galón):");
double consumo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe el precio del galón de combustible:");
double precioGalon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe el número de pasajeros:");
int pasajeros = Convert.ToInt32(Console.ReadLine());

double galonesNecesarios = distancia / consumo;
double costoTotal = galonesNecesarios * precioGalon;
double costoPorPasajero = costoTotal / pasajeros;

Console.WriteLine($"\nGalones necesarios: {galonesNecesarios:F2}");
Console.WriteLine($"Costo total del combustible: RD${costoTotal:F2}");
Console.WriteLine($"Costo por pasajero: RD${costoPorPasajero:F2}");
