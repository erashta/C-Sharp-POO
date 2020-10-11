//Patrón: Factory Method
using System;

namespace PatronDiseno {
	class Circulo : IFigura {
		public void Dibujar() {
			Console.WriteLine("Se hace el dibujo de un círculo");
		}
	}
}
