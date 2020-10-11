using System;

namespace Ejemplo {

	//Inicia la aplicación aquí
	class Program {
		static void Main() {
			Hija objHija = new Hija();
			objHija.Aviso();
			objHija.Mensaje();
			objHija.MetodoA();
			objHija.ProcedimientoA();
			Console.ReadKey();
		}
	}
}
