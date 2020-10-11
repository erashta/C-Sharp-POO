//Patrón: Builder
namespace PatronDiseno {
	class CaFeFrio : BebidaFria {
		public override float Precio() {
			return 4000;
		}

		public override string Nombre() {
			return "Café frío";
		}
	}
}
