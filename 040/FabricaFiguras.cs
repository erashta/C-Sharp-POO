//Patrón: Factory Method

namespace PatronDiseno {
	class FabricaFiguras {
		//Dependiendo del parámetro retorna uno u otro objeto 
		public IFigura GetFigura(string TipoFigura) {
			if (TipoFigura.Equals("CIRCULO")) return new Circulo();
			if (TipoFigura.Equals("RECTANGULO")) return new Rectangulo();
			if (TipoFigura.Equals("TRIANGULO")) return new Triangulo();
			return null;
		}
	}
}
