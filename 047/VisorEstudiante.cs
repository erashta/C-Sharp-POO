//Patrón de diseño: Modelo Vista Controlador
using System;

namespace PatronDiseno {
	class VisorEstudiante {
		public void ImprimeDetallesEstudiante(string NombreEstudiante, string CodigoEstudiante) {
			Console.WriteLine("Estudiante: ");
			Console.WriteLine("Nombre: " + NombreEstudiante);
			Console.WriteLine("Código: " + CodigoEstudiante);
		}
	}
}
