//Patrón: Abstract Factory
namespace PatronDiseno {
	public abstract class FabricaAbstracta {
		public abstract IFigura GetFigura(string TipoFigura);
		public abstract IColor GetColor(string color);
	}
}
