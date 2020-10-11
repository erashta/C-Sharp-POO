using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			//Acediendo a métodos estáticos
			double AreaUnCirculo = Geometria.AreaCirculo(7);
			Console.WriteLine("Área círculo es: " + AreaUnCirculo.ToString());
			
			//Accediendo a atributos estáticos
			Console.WriteLine("Cadena es: " + Geometria.unaCadena);
			Console.WriteLine("Valor entero es: " + Geometria.valorEntero);
			Console.WriteLine("Valor real es: " + Geometria.valorReal);

			//Se instancia la clase
			Geometria objGeometria = new Geometria();
			double Esfera = objGeometria.VolumenEsfera(7);
			Console.WriteLine("Volumen Esfera: " + Esfera.ToString());
			Console.ReadKey();
		}
	}
}
