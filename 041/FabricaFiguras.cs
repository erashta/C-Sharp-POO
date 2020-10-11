//Patrón: Abstract Factory
namespace PatronDiseno {
	public class FabricaFiguras : FabricaAbstracta {
		//Dependiendo del parámetro retorna uno u otro objeto 
		public override IFigura GetFigura(string TipoFigura) {
			if (TipoFigura.Equals("CIRCULO")) return new Circulo();
			if (TipoFigura.Equals("RECTANGULO")) return new Rectangulo();
			if (TipoFigura.Equals("TRIANGULO")) return new Triangulo();
			return null;
		}

		public override IColor GetColor(string color) {
			return null;
		}
	}
}
