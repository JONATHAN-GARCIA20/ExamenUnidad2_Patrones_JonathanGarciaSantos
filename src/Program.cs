using System;

namespace ExamenUnidad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RESERVA Y SEGUIMIENTO DE TRANSPORTES - PATRONES OBJECT POOL & SINGLETON";

            AdministradorRutas admin = AdministradorRutas.ObtenerInstancia();
            VehiculoPool pool = new VehiculoPool(5);

            Console.WriteLine("\nSISTEMA DE RESERVA Y SEGUIMIENTO DE TRANSPORTES");
            admin.MostrarRuta();

            bool salir = false;
            
            while (!salir)
            {
                Console.WriteLine("\nMENÚ PRINCIPAL");
                Console.WriteLine("1. Asignar un vehículo por placa");
                Console.WriteLine("2. Liberar un vehículo por placa");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        pool.MostrarEstado();
                        Console.Write("\nIngresa la placa del vehículo a asignar (ej. T001): ");
                        string placaAsignar = Console.ReadLine();
                        pool.AsignarVehiculo(placaAsignar);
                        break;

                    case "2":
                        pool.MostrarEstado();
                        Console.Write("\nIngresa la placa del vehículo a liberar (ej. T001): ");
                        string placaLiberar = Console.ReadLine();
                        pool.LiberarVehiculo(placaLiberar);
                        break;

                    case "3":
                        salir = true;
                        Console.WriteLine("\nSaliendo del sistema... ¡Gracias!");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida, intenta de nuevo.");
                        break;
                }
            }
        }
    }
}
