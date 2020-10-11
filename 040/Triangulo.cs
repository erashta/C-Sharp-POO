//Patrón: Factory Method
using System;

namespace PatronDiseno {
	class Triangulo : IFigura {
		public void Dibujar() {
			Console.WriteLine("Ahora se dibuja un triángulo");
		}
	}
}
