//Patrón de diseño: Adapter
using System;

namespace PatronDiseno {
	class EjecutorMP4 : IEjecutorAvanzadoArchivosMultimedia {

		public void EjecutaVLC(string NombreArchivo) {
		}

		public void EjecutaMP4(string NombreArchivo) {
			Console.WriteLine("Ejecutando un archivo MP4. Nombre: " + NombreArchivo);
		}
	}
}
