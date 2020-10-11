//Patrón: Abstract Factory
namespace PatronDiseno {
	class FabricaColores : FabricaAbstracta {
		//Dependiendo del parámetro retorna uno u otro objeto 
		public override IFigura GetFigura(string TipoFigura) {
			return null;
		}

		public override IColor GetColor(string color) {
			if (color.Equals("ROJO")) return new Rojo();
			if (color.Equals("VERDE")) return new Verde();
			if (color.Equals("AZUL")) return new Azul();
			return null;
		}
	}
}
