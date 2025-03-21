using System;

namespace herenciaPolimorfismo.MisClases
{
    internal class motocicleta : Vehiculo
    {
        private int cargaBateria;
        public motocicleta(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            velocidadMaxima = 200;
            peso = 546;
            CapacidadTanque = 13;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }

        public int velocidadMaxima { get; set; }
        public int peso { get; set; }
        public int CapacidadTanque { get; set; }
        
        

    }
}