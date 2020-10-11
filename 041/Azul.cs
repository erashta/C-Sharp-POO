//Patrón: Abstract Factory
using System;

namespace PatronDiseno {
	class Azul : IColor {
		public void Rellenar() {
			Console.WriteLine("Ahora de azul es rellenado");
		}
	}
}
