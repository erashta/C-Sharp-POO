//Patrón: Singleton
using System;

namespace PatronDiseno {
	class ObjetoUnico {
		//Genera un objeto de ObjetoUnico
		private static ObjetoUnico instancia = new ObjetoUnico();

		//Hace el constructor privado por lo que no puede ser instanciado
		private ObjetoUnico() { }

		//Retorna la única instancia de esta clase
		public static ObjetoUnico GetInstancia() {
			return instancia;
		}

		public void Mensaje() {
			Console.WriteLine("Esta es una prueba");
		}

	}
}
