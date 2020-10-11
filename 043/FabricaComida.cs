//Patrón: Builder
namespace PatronDiseno {
	//Prepara la comida dependiendo si es vegetariana o no
	class FabricaComida {
		public Comida PrepararComidaVegetariana() {
			Comida miComida = new Comida();
			miComida.AddItem(new HamburguesaVegetariana());
			miComida.AddItem(new CaFeFrio());
			return miComida;
		}

		public Comida PrepararComidaNoVegetariana() {
			Comida miComida = new Comida();
			miComida.AddItem(new HamburguesaPollo());
			miComida.AddItem(new Malteada());
			return miComida;
		}
	}
}
