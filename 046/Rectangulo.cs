//Patrón de diseño: Facade
using System;

namespace PatronDiseno {
	class Rectangulo : IFigura {
		public void Dibujar() {
			Console.WriteLine("Traza un rectángulo");
		}
	}
}
