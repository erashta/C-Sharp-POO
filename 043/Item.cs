//Patrón: Builder
namespace PatronDiseno {
	//Todo producto en la comida tendrá estos ítems: Nombre, como se empaca, precio
	public interface Item {
		string Nombre();

		IEmpacado EmpacandoProducto();

		float Precio();

	}
}
