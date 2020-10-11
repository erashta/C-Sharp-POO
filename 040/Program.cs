//Patrón: Factory Method
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			FabricaFiguras objeto = new FabricaFiguras();

			//Obtiene un objeto círculo 
			IFigura Figura1 = objeto.GetFigura("CIRCULO");

			//Llama el método de dibujar del objeto círculo
			Figura1.Dibujar();

			//Obtiene un objeto rectángulo
			IFigura Figura2 = objeto.GetFigura("RECTANGULO");

			//Llama el método de dibujar del objeto rectángulo
			Figura2.Dibujar();

			//Obtiene un objeto triángulo
			IFigura Figura3 = objeto.GetFigura("TRIANGULO");

			//Llama el método de dibujar del objeto triángulo
			Figura3.Dibujar();

			Console.ReadKey();
		}
	}
}
