using System;

namespace Ejemplo {
	
	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto de MiClase
			MiClase Objeto = new MiClase();

			//Llama los setters
			Objeto.Cadena = "Suini, Capuchina, Grisú, Milú, Sally, Vikingo";
			Objeto.Numero = 7;
			Objeto.Letra = 'R';
			Objeto.Valor = 93.5;

			//Usa los getters
			Console.WriteLine(Objeto.Letra.ToString());
			Console.WriteLine(Objeto.Valor.ToString());
			Console.WriteLine(Objeto.Cadena);
			Console.WriteLine(Objeto.Numero.ToString());

			Console.ReadKey();
		}
	}
}
