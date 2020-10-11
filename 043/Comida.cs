//Patrón: Builder
using System;
using System.Collections.Generic;

namespace PatronDiseno {
	class Comida {
		private List<Item> items = new List<Item>();

		public void AddItem(Item item) {
			items.Add(item);
		}

		public float GetCosto() {
			float costo = 0.0f;

			foreach (Item item in items) {
				costo += item.Precio();
			}
			return costo;
		}

		public void MostrarItems() {

			foreach (Item item in items) {
				Console.WriteLine("Item: " + item.Nombre());
				Console.WriteLine(", Empaque: " + item.EmpacandoProducto().Empaque());
				Console.WriteLine(", Precio: " + item.Precio());
			}
		}

	}
}
