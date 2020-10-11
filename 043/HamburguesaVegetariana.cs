//Patrón: Builder
namespace PatronDiseno {
	class HamburguesaVegetariana : Hamburguesa {
		public override float Precio() {
			return 5000;
		}

		public override string Nombre() {
			return "Hamburguesa vegetariana";
		}
	}
}
