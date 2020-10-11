using System;

namespace Ejemplo {
	
	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto de MiClase
			MiClase Objeto = new MiClase();

			//Llama a un método público de MiClase
			double resultado = Objeto.CalculaPromedio(1, 7, 8);

			Console.WriteLine(resultado.ToString());
			Console.ReadKey();
		}
	}
}
