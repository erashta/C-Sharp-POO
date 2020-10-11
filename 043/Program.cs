//Patrón: Builder
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			FabricaComida miComida = new FabricaComida();

			Comida vegetariano = miComida.PrepararComidaVegetariana();
			Console.WriteLine("Comida vegetariana");
			vegetariano.MostrarItems();
			Console.WriteLine("Costo total: " + vegetariano.GetCosto());

			Comida noVegetariano = miComida.PrepararComidaNoVegetariana();
			Console.WriteLine("\n\nComida No vegetariana");
			noVegetariano.MostrarItems();
			Console.WriteLine("Costo total: " + noVegetariano.GetCosto());

			Console.ReadKey();
		}
	}
}
