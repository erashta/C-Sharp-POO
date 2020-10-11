//Patrón de diseño: Composite
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			Empleado Gerente = new Empleado("Laura", "Gerente", 5000000);
			Empleado jefeVentas = new Empleado("Patricia", "Jefa de Ventas", 3000000);
			Empleado jefeMercadeo = new Empleado("Adriana", "Jefa de Mercadeo", 3000000);
			Empleado disenador1 = new Empleado("Sandra", "Marketing", 2000000);
			Empleado disenador2 = new Empleado("Alejandra", "Marketing", 2000000);
			Empleado vendedor1 = new Empleado("Francisca", "Ventas", 200000);
			Empleado vendedor2 = new Empleado("Flor", "Ventas", 2000000);

			Gerente.Adicionar(jefeVentas);
			Gerente.Adicionar(jefeMercadeo);

			jefeVentas.Adicionar(vendedor1);
			jefeVentas.Adicionar(vendedor2);

			jefeMercadeo.Adicionar(disenador1);
			jefeMercadeo.Adicionar(disenador2);

			//Imprime todos los empleados de la organización
			Console.WriteLine(Gerente.ToString());

			foreach (Empleado jefe in Gerente.GetSubordinados()) {
				Console.WriteLine(jefe.ToString());

				foreach (Empleado empleado in jefe.GetSubordinados()) {
					Console.WriteLine(empleado.ToString());
				}
			}
			Console.ReadKey();
		}
	}
}
