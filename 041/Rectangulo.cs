//Patrón: Abstract Factory
using System;

namespace PatronDiseno {
	class Rectangulo : IFigura {
		public void Dibujar() {
			Console.WriteLine("Estoy dibujando un rectángulo");
		}
	}
}
