using System;

namespace herenciaPolimorfismo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            cargaBateria = 50;
            capacidadBateria = 1000;
            tiempoCarga = 4;
        
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }


        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }
        public int capacidadBateria { get; set; }

        public int tiempoCarga{ get; set; }

        

    }
}