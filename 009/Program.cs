using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto
			MiClase objetoA = new MiClase();
			objetoA.UnMetodo(48, "Rafael");
			objetoA.UnMetodo("Alberto", 26);
			objetoA.UnMetodo(1994.06, 48);
			objetoA.UnMetodo("Moreno Parra", 1683.29);
			Console.ReadKey();
		}
	}
}
