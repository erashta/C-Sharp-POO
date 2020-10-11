using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Se instancia la clase la primera vez
			Geometria objGeometria = new Geometria();
			double Esfera = objGeometria.VolumenEsfera(7);
			Console.WriteLine("Volumen Esfera A: " + Esfera.ToString());

			//Se instancia la clase la segunda vez
			Geometria objOtro = new Geometria();
			double OtraEsfera = objOtro.VolumenEsfera(7);
			Console.WriteLine("Volumen Esfera B: " + OtraEsfera.ToString());

			Console.ReadKey();
		}
	}
}
