//Patrón: Abstract Factory
using System;

namespace PatronDiseno {
	class Rojo : IColor {
		public void Rellenar() {
			Console.WriteLine("Pinta de rojo");
		}
	}
}
