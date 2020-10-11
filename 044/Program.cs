//Patrón de diseño: Adapter
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			EjecutorAudio Multimedia = new EjecutorAudio();

			Multimedia.Ejecutar("mp3", "MiMusica.mp3");
			Multimedia.Ejecutar("mp4", "unSonido.mp4");
			Multimedia.Ejecutar("vlc", "FondoMusical.vlc");
			Multimedia.Ejecutar("avi", "unAudio.avi");

			Console.ReadKey();
		}
	}
}
