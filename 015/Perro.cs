namespace Ejemplo {
    class Perro:Mascota {
		//Real Sociedad Canina de España
		public string ReconocimientoRSCE { get; set; }

		//United Kennel Club
		public string ReconocimientoUKC { get; set; }

		//Crianza
		public string CriadoPara { get; set; }

		public double AlturaALaCruz { get; set; }
		public int TendenciaBabear { get; set; } //0. Ninguna, 1. Baja, 2. Moderada
		public int TendenciaRoncar { get; set; }
		public int TendenciaLadrar { get; set; }
		public int TendenciaExcavar { get; set; }
	}
}
