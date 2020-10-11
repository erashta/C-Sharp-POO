//Patrón de diseño: Adapter
using System;

namespace PatronDiseno {
	class EjecutorVLC : IEjecutorAvanzadoArchivosMultimedia {

		public void EjecutaVLC(string NombreArchivo) {
			Console.WriteLine("Ejecutando un archivo VLC. Nombre: " + NombreArchivo);
		}

		public void EjecutaMP4(string NombreArchivo) {
		}
	}
}
