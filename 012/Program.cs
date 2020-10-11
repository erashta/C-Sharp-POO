using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto
			MiClase objetoA = new MiClase();
			MiClase objetoB = new MiClase(48);
			MiClase objetoC = new MiClase(1972.06, 26);
			MiClase objetoD = new MiClase("Ramp", 48);
			MiClase objetoE = new MiClase("Moreno Parra", 1683.29, 29);
			Console.ReadKey();
		}
	}
}
