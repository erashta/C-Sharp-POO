//Patrón de diseño: Adapter
namespace PatronDiseno {
	public interface IEjecutorAvanzadoArchivosMultimedia {
		void EjecutaVLC(string NombreArchivo);

		void EjecutaMP4(string NombreArchivo);
	}
}
