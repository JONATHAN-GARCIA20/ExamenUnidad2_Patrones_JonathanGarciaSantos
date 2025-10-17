using System;

namespace ExamenUnidad2
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public bool EnUso { get; set; }

        public Vehiculo(string placa, string tipo)
        {
            Placa = placa;
            Tipo = tipo;
            EnUso = false;
        }

        public void Asignar()
        {
            EnUso = true;
            Console.WriteLine($"\nVehículo {Placa} ({Tipo}) asignado correctamente.");
        }

        public void Liberar()
        {
            EnUso = false;
            Console.WriteLine($"\nVehículo {Placa} ({Tipo}) liberado y listo para reutilizar.");
        }

        public override string ToString()
        {
            return $"[{Placa}] - {Tipo} - {(EnUso ? "En uso" : "Disponible")}";
        }
    }
}
