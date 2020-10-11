//Patrón de diseño: Modelo Vista Controlador
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			Estudiante modelo = TraeEstudianteBaseDatos();
			VisorEstudiante vista = new VisorEstudiante();
			ControladorEstudiante controlador = new ControladorEstudiante(modelo, vista);

			controlador.ActualizarVista();
			controlador.setNombreEstudiante("Laura");
			controlador.ActualizarVista();

			Console.ReadKey();
		}

		private static Estudiante TraeEstudianteBaseDatos() {
			Estudiante estudiante = new Estudiante();
			estudiante.Nombre = "Johanna";
			estudiante.Codigo = "17123456";
			return estudiante;
		}
	}
}
