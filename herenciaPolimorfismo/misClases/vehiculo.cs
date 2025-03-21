using System;

namespace herenciaPolimorfismo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get;  }
        public int Year { get;  }

        private int velocidad = 0;



        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}:", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("Vas a {0} KMS / Hora",velocidad);
        }
        public virtual void frenar()
        {
            Console.WriteLine($"{Modelo} Está frenando.");
        }

        public void apagar()
        {
            Console.WriteLine($"{Modelo} Está apagado.");
        }
        public void encender()
        {
            Console.WriteLine($"{Modelo} Está encendido.");
        }
    }
}
