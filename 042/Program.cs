//Patrón: Singleton
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			//Quite el comentario de esta instrucción y generará un error al compilar
			//ObjetoUnico pruebaObjeto = new ObjetoUnico();

			//Obtiene el único objeto instanciable
			ObjetoUnico miObjeto = ObjetoUnico.GetInstancia();

			//Muestra un mensaje
			miObjeto.Mensaje();

			Console.ReadKey();
		}
	}
}
