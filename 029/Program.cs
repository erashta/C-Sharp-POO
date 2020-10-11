using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia las clases
			Cuadrado objCuadrado = new Cuadrado(5);
			Circulo objCirculo = new Circulo(5);

			//Imprime los valores
			objCuadrado.ImprimeArea();
			objCuadrado.ImprimePerimetro();

			objCirculo.ImprimeArea();
			objCirculo.ImprimePerimetro();

			Console.ReadKey();
		}
	}
}
