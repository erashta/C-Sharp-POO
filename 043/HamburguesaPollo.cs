//Patrón: Builder
namespace PatronDiseno {
	public class HamburguesaPollo : Hamburguesa {
		public override float Precio() {
			return 7000;
		}

		public override string Nombre() {
			return "Hamburguesa de pollo";
		}
	}
}
