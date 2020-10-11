using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto de MiClase
			MiClase Objeto = new MiClase();
			MiClase Otro = new MiClase();

			//Llama los setters
			Objeto.Edad = 17;
			Otro.Edad = -8;

			Console.WriteLine("Edad es: " + Objeto.Edad.ToString());
			Console.WriteLine("Edad es: " + Otro.Edad.ToString());

			Console.ReadKey();
		}
	}
}
