//Patrón de diseño: Composite
using System.Collections.Generic;

namespace PatronDiseno {
	public class Empleado {
		private string nombre;
		private string departamento;
		private int salario;
		private List<Empleado> subordinados;

		//Constructor
		public Empleado(string nombre, string departamento, int salario) {
			this.nombre = nombre;
			this.departamento = departamento;
			this.salario = salario;
			subordinados = new List<Empleado>();
		}

		public void Adicionar(Empleado objEmpleado) {
			subordinados.Add(objEmpleado);
		}

		public void Quitar(Empleado objEmpleado) {
			subordinados.Remove(objEmpleado);
		}

		public List<Empleado> GetSubordinados() {
			return subordinados;
		}

		public new string ToString() {
			return "Empleado => Nombre: " + nombre + ", departamento: " + departamento + ", salario: " + salario.ToString();
		}
	}
}
