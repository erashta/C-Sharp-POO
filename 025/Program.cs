using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			double unRadio = 7;
			double AreaUnCirculo = Geometria.AreaCirculo(unRadio);
			Console.WriteLine("Área círculo es: " + AreaUnCirculo.ToString());
			
			double AreaTri = Geometria.AreaTriangulo(3, 4, 5);
			Console.WriteLine("Área triángulo es: " + AreaTri.ToString());

			//Instancio la clase
			Geometria objGeometria = new Geometria();
			double Esfera = objGeometria.VolumenEsfera(7);
			Console.WriteLine("Volumen Esfera: " + Esfera.ToString());
			Console.ReadKey();
		}
	}
}
