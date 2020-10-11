//Patrón de diseño: Facade
using System;

namespace PatronDiseno {
	class Triangulo : IFigura {
		public void Dibujar() {
			Console.WriteLine("Delinea un triángulo");
		}
	}
}
