//Patrón: Factory Method
using System;

namespace PatronDiseno {
	class Rectangulo : IFigura {
		public void Dibujar() {
			Console.WriteLine("Estoy dibujando un rectángulo");
		}
	}
}
