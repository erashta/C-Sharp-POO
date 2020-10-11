namespace Ejemplo {
	class Perro : Mascota {
		//Crianza
		public string CriadoPara { get; set; }
		public double AlturaALaCruz { get; set; }

		public void DatosPerro(string Nombre, char Sexo, string Propietario) {
			this.Nombre = Nombre;
			this.Sexo = Sexo;
			this.Propietario = Propietario;
        }
	}
}
