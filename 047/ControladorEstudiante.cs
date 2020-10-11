//Patrón de diseño: Modelo Vista Controlador
namespace PatronDiseno {
	class ControladorEstudiante {
		private Estudiante modelo;
		private VisorEstudiante vista;

		public ControladorEstudiante(Estudiante modelo, VisorEstudiante vista) {
			this.modelo = modelo;
			this.vista = vista;
		}

		public void setNombreEstudiante(string nombre) {
			modelo.Nombre = nombre;
		}

		public string getNombreEstudiante() {
			return modelo.Nombre;
		}

		public void setCodigoEstudiante(string codigo) {
			modelo.Codigo = codigo;
		}

		public string getCodigoEstudiante() {
			return modelo.Codigo;
		}

		public void ActualizarVista() {
			vista.ImprimeDetallesEstudiante(modelo.Nombre, modelo.Codigo);
		}
	}
}
