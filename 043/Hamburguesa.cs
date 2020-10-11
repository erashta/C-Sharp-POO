//Patrón: Builder
namespace PatronDiseno {
	public abstract class Hamburguesa : Item {

		public IEmpacado EmpacandoProducto() {
			return new Envoltura();
		}

		public abstract float Precio();

		public abstract string Nombre();

	}
}
