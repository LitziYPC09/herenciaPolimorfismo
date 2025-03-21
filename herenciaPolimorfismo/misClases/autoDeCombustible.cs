using System;

namespace herenciaPolimorfismo.MisClases
{
    internal class autoDeCombustible : Vehiculo
    {
        
        public autoDeCombustible(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            consumoPorKilometro = 10;
            TipoDeCombustible = "Gasolina";
            Kilometraje = 9511;

        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Kilometraje += cuanto;
        }
        public void apagar()
        {
            Console.WriteLine($"{Modelo} Está apagado.");
        }

        public int consumoPorKilometro { get; set; }
        public string TipoDeCombustible { get; set; }
        public int Kilometraje { get; set; }

        

    }
}