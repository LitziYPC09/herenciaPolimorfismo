using System;

namespace herenciaPolimorfismo.MisClases
{
    internal class Camion : Vehiculo
    {
        
        public Camion (int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            TipoDeCombustible = "Gasolina";
            Kilometraje = 7556 ;
            TieneRemolque = false;


        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Kilometraje += cuanto;
        }

    
        public string TipoDeCombustible { get; set; }
        public int Kilometraje { get; set; }
        public bool TieneRemolque { get; set; }

        

    }
}