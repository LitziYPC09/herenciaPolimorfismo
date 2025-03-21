using herenciaPolimorfismo.MisClases;

// CARRO ELECTRONICO
Console.WriteLine("==CARRO ELECTRONICO==");
Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");

Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

miBYD.InformacionVehiculo();
miBYD.cargarBateria();

// Propiedades de la clase CarroElectrico (agregadas)
Console.WriteLine("El nivel de bateria es: {0}", miBYD.NivelBateria());
miBYD.capacidadBateria = 1000;
Console.WriteLine("La capacidad de la bateria es: {0}", miBYD.capacidadBateria);
miBYD.tiempoCarga = 4;
Console.WriteLine("El tiempo de carga es: {0}", miBYD.tiempoCarga);
miBYD.frenar();
miBYD.acelerar(20);

Console.WriteLine();


// AUTO DE COMBUSTIBLE
Console.WriteLine("==AUTO DE COMBUSTIBLE==");

autoDeCombustible miAuto = new autoDeCombustible(2025, "negro", "Chevrolet Spark");

miAuto.InformacionVehiculo();
Console.WriteLine("Consumo por kilómetro: {0} litros/km", miAuto.consumoPorKilometro);
Console.WriteLine("Tipo de combustible: {0}", miAuto.TipoDeCombustible);
Console.WriteLine("Kilometraje: {0} km", miAuto.Kilometraje);
miAuto.apagar();
miAuto.encender();
miAuto.acelerar(10);

Console.WriteLine();

// MOTOCICLETA
Console.WriteLine("==MOTOCICLETA==");

motocicleta miMoto = new motocicleta(2026, "Verde", "Harley Davidson");

miMoto.InformacionVehiculo();
Console.WriteLine("La velocidad maxima es: {0}", miMoto.velocidadMaxima);
Console.WriteLine("El peso es: {0}", miMoto.peso);
Console.WriteLine("La capacidad del tanque es: {0}", miMoto.CapacidadTanque);
miMoto.acelerar(20);
miMoto.frenar();

Console.WriteLine();

// CAMION
Console.WriteLine("==CAMION==");

Camion miCamion = new Camion(2019, "Blanco", "Kenworth T680");

miCamion.InformacionVehiculo();
Console.WriteLine("Tipo de Combustible: {0}", miCamion.TipoDeCombustible);
Console.WriteLine("Kilometraje: {0}", miCamion.Kilometraje);
Console.WriteLine("¿Tiene remolque? {0}", miCamion.TieneRemolque ? "Sí" : "No");
miCamion.acelerar(50);
miCamion.frenar();