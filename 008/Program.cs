using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Instancia o crea un objeto Geometria
			Geometria geometria = new Geometria();

			//Dependiendo del número de parámetros llama a un método u otro
			double areaCirculo = geometria.Area(8);
			double areaTriangulo = geometria.Area(4, 5, 6);
			double areaRectangulo = geometria.Area(17, 19);

			Console.WriteLine("Área del círculo: " + areaCirculo.ToString());
			Console.WriteLine("Área del triángulo: " + areaTriangulo.ToString());
			Console.WriteLine("Área del rectángulo: " + areaRectangulo.ToString());

			Console.ReadKey();
		}
	}
}
