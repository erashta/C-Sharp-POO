//Patrón de diseño: Adapter
namespace PatronDiseno {
	class AdaptadorMultimedia : IEjecutorMultimedia {

		IEjecutorAvanzadoArchivosMultimedia ejecutorAvanzado;

		//Constructor
		public AdaptadorMultimedia(string TipoAudio) {

			if (TipoAudio.Equals("vlc")) {
				ejecutorAvanzado = new EjecutorVLC();
			}
			if (TipoAudio.Equals("mp4")) {
				ejecutorAvanzado = new EjecutorMP4();
			}
		}

		//Dependiendo del tipo de audio llama a VLC o MP4
		public void Ejecutar(string TipoAudio, string NombreArchivo) {

			if (TipoAudio.Equals("vlc")) {
				ejecutorAvanzado.EjecutaVLC(NombreArchivo);
			}
			else if (TipoAudio.Equals("mp4")) {
				ejecutorAvanzado.EjecutaMP4(NombreArchivo);
			}
		}
	}
}
