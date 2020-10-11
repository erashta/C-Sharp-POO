using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			Mascota objMascota = new Mascota();
			Gato objGato = new Gato();
			Perro objPerro = new Perro();

			//Da valores a la instancia de gato
			objGato.DatosGato("Sally", 'H', "Rafael Moreno");

			//Da valores a la instancia de perro
			objPerro.DatosPerro("Kitty", 'H', "Chloe Perry");

			//Intenta acceder a los métodos protegidos de Mascota
			objMascota.Nombre = "Milú";

			Console.ReadKey();
		}
	}
}
