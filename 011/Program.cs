using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto de MiClase llamando el constructor
			MiClase Mascotas = new MiClase(2016, 'T', "Tammy", 12.17);

			//Se imprimen los valores de ambas variables
			Console.WriteLine("Letra en Mascotas es: " + Mascotas.Letra.ToString());
			Console.WriteLine("Valor en Mascotas es: " + Mascotas.Valor.ToString());

			Console.ReadKey();
		}
	}
}