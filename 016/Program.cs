using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			Mascota objMascota = new Mascota();
			Gato objGato = new Gato();
			Perro objPerro = new Perro();

			//Da valores a la instancia de mascota
			objMascota.Correo = "enginelife@hotmail.com";
			objMascota.ColorOjos = 1;

			//Da valores a la instancia de gato
			objGato.Correo = "ramsoftware@gmail.com";
			objGato.Propietario = "Rafael Alberto Moreno Parra";
			objGato.Nombre = "Sally";
			objGato.Sexo = 'H';
			objGato.PatronPelo = "Tricolor";

			//Da valores a la instancia de perro
			objPerro.Raza = "Pastor Alemán";
			objPerro.Sexo = 'M';
			objPerro.Nombre = "Firuláis";
			objPerro.TendenciaLadrar = 1;

			Console.ReadKey();
		}
	}
}
