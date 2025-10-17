using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenUnidad2
{
    public class VehiculoPool
    {
        private List<Vehiculo> vehiculosDisponibles;
        private List<Vehiculo> vehiculosEnUso;

        public VehiculoPool(int cantidad)
        {
            vehiculosDisponibles = new List<Vehiculo>();
            vehiculosEnUso = new List<Vehiculo>();

            for (int i = 1; i <= cantidad; i++)
            {
                vehiculosDisponibles.Add(new Vehiculo($"T{i:000}", "Transporte"));
            }
        }

        public void MostrarEstado()
        {
            Console.WriteLine("\nESTADO ACTUAL DE VEHÍCULOS:");
            Console.WriteLine("PLACA\t\tTIPO\t\tESTADO");
            Console.WriteLine("------------------------------------------");

            foreach (var v in vehiculosDisponibles)
                Console.WriteLine($"{v.Placa}\t\t{v.Tipo}\t\tDisponible");
            foreach (var v in vehiculosEnUso)
                Console.WriteLine($"{v.Placa}\t\t{v.Tipo}\t\tEn uso");
        }

        public void AsignarVehiculo(string placa)
        {
            Vehiculo v = vehiculosDisponibles.FirstOrDefault(x => x.Placa == placa);
            if (v != null)
            {
                v.Asignar();
                vehiculosDisponibles.Remove(v);
                vehiculosEnUso.Add(v);
                MostrarEstado();
            }
            else
            {
                Console.WriteLine("\nNo se encontró el vehículo disponible o ya está en uso.");
            }
        }

        public void LiberarVehiculo(string placa)
        {
            Vehiculo v = vehiculosEnUso.FirstOrDefault(x => x.Placa == placa);
            if (v != null)
            {
                v.Liberar();
                vehiculosEnUso.Remove(v);
                vehiculosDisponibles.Add(v);
                MostrarEstado();
            }
            else
            {
                Console.WriteLine("\nNo se encontró ese vehículo en uso.");
            }
        }
    }
}
