//Patrón: Abstract Factory
using System;

namespace PatronDiseno {
	class Verde : IColor {
		public void Rellenar() {
			Console.WriteLine("Un verde es pintado");
		}
	}
}
