//Patrón de diseño: Facade
using System;

namespace PatronDiseno {
	class Circulo : IFigura {
		public void Dibujar() {
			Console.WriteLine("Dibujando un círculo");
		}
	}
}
