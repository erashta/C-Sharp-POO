//Patrón de diseño: Facade
namespace PatronDiseno {
	class HacerFigura {
		private IFigura circulo;
		private IFigura rectangulo;
		private IFigura triangulo;

		public HacerFigura() {
			circulo = new Circulo();
			rectangulo = new Rectangulo();
			triangulo = new Triangulo();
		}

		public void DibujaCirculo() {
			circulo.Dibujar();
		}

		public void DibujaRectangulo() {
			rectangulo.Dibujar();
		}

		public void DibujaTriangulo() {
			triangulo.Dibujar();
		}
	}
}
