//Patrón: Builder
namespace PatronDiseno {
	public abstract class BebidaFria : Item {
		public IEmpacado EmpacandoProducto() {
			return new Botella();
		}

		public abstract float Precio();

		public abstract string Nombre();
	}
}
