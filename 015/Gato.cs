namespace Ejemplo {
    class Gato:Mascota {
		public string PatronPelo { get; set; }
		public int TendenciaPerderPelo { get; set; }

		public string ReconocimientoCFA { get; set; } //Asociación de Criadores de Gatos
		public string ReconocimientoACFA { get; set; } //Asociación Americana de Criadores de Gatos
		public string ReconocimientoFIFe { get; set; } //Fédération Internationale Féline 
		public string ReconocimientoTICA { get; set; } //Asociación Internacional de Gatos
	}
}
