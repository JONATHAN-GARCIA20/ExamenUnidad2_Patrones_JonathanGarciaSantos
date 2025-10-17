using System;

namespace ExamenUnidad2
{
    public class AdministradorRutas
    {
        private static AdministradorRutas? instancia;
        private static readonly object bloqueo = new object();
        public string RutaPrincipal { get; private set; }

        private AdministradorRutas()
        {
            RutaPrincipal = "RUTA CENTRAL - TIJUANA a MEXICALI";
            Console.WriteLine("ADMINISTRADOR DE RUTAS INICIALIZADO.");
        }

        public static AdministradorRutas ObtenerInstancia()
        {
            if (instancia == null)
            {
                lock (bloqueo)
                {
                    if (instancia == null)
                        instancia = new AdministradorRutas();
                }
            }
            return instancia;
        }

        public void MostrarRuta()
        {
            Console.WriteLine($"\nRUTA PRINCIPAL DEL SISTEMA: {RutaPrincipal}");
        }
    }
}
