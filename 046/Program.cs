//Patrón de diseño: Facade
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			HacerFigura hacefigura = new HacerFigura();

			hacefigura.DibujaCirculo();
			hacefigura.DibujaRectangulo();
			hacefigura.DibujaTriangulo();

			Console.ReadKey();
		}
	}
}
