//Patrón de diseño: Adapter
using System;

namespace PatronDiseno {
	class EjecutorAudio : IEjecutorMultimedia {

		AdaptadorMultimedia adaptadorMultimedia;

		public void Ejecutar(string TipoAudio, string NombreArchivo) {
			//Archivos MP3
			if (TipoAudio.Equals("mp3")) {
				Console.WriteLine("Ejecutando archivo MP3. Nombre: " + NombreArchivo);
			} //Otros formatos
			else if (TipoAudio.Equals("vlc") || TipoAudio.Equals("mp4")) {
				adaptadorMultimedia = new AdaptadorMultimedia(TipoAudio);
				adaptadorMultimedia.Ejecutar(TipoAudio, NombreArchivo);
			}
			else {
				Console.WriteLine("Medio inválido. (" + TipoAudio + ") es un formato no soportado");
			}
		}
	}
}
