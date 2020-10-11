//Patrón: Abstract Factory
namespace PatronDiseno {
	class ProductorDeFabricas {
		public static FabricaAbstracta GetFabrica(string seleccion) {
			if (seleccion.Equals("FIGURA")) return new FabricaFiguras();
			if (seleccion.Equals("COLOR")) return new FabricaColores();
			return null;
		}
	}
}
