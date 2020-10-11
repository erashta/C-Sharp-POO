using System;

namespace Ejemplo {
    class Mascota {
		public string SerialChip { get; set; }
		public string Nombre { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public char Sexo { get; set; } //Macho, Hembra
		public string Propietario { get; set; } //Nombre del propietario
		public string Telefono { get; set; } //Teléfono del propietario
		public string Correo { get; set; } //Correo electrónico del propietario
		public double Peso { get; set; }
		public int ColorOjos { get; set; } //0. Azul, 1. Verde, 2. Dorado, 3. Dispar
		public int EsperanzaVidaMinimo { get; set; }
		public int EsperanzaVidaMaximo { get; set; }
		public int NecesidadAtencion { get; set; } //0. Baja, 1. Media, 2. Alta

		public string Raza { get; set; }
	}
}
