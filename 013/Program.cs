using System;

namespace Ejemplo {
	
	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto de MiClase llamando el constructor
			MiClase Mascotas = new MiClase(2016, 'T', "Tammy", 12.17);

			//Hace una copia de ese objeto
			MiClase UnaCopia = Mascotas.CopiarObjeto();

			//Se imprimen los valores de los dos objetos
			Console.WriteLine("Después de copiar");
			Console.WriteLine("Cadena en Mascotas es: " + Mascotas.Cadena);
			Console.WriteLine("Cadena en UnaCopia es: " + UnaCopia.Cadena);

			//Cambia el valor de cadena en UnaCopia
			UnaCopia.Cadena = "Krousky";

			//Imprime de nuevo los valores
			Console.WriteLine("\r\nDespués de cambiar la cadena");
			Console.WriteLine("Cadena en Mascotas es: " + Mascotas.Cadena);
			Console.WriteLine("Cadena en UnaCopia es: " + UnaCopia.Cadena);

			Console.ReadKey();
		}
	}
}
