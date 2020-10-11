namespace Ejemplo {
	class Gato : Mascota {
		public string PatronPelo { get; set; }
		public int TendenciaPerderPelo { get; set; }
		public void DatosGato(string Nombre, char Sexo, string Propietario) {
			this.Nombre = Nombre;
			this.Sexo = Sexo;
			this.Propietario = Propietario;
		}
	}
}
