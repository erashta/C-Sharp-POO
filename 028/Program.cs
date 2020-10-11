using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia las clases
			Cuadrado objCuadrado = new Cuadrado(5);
			Circulo objCirculo = new Circulo(5);

			//Imprime los valores
			Console.WriteLine("Área del círculo: " + objCirculo.AreaFigura().ToString());
			Console.WriteLine("Área del cuadrado: " + objCuadrado.AreaFigura().ToString());
			Console.WriteLine("Perímetro del círculo: " + objCirculo.PerimetroFigura().ToString());
			Console.WriteLine("Perímetro del cuadrado: " + objCuadrado.PerimetroFigura().ToString());

			Console.ReadKey();
		}
	}
}
