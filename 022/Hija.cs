using System;

namespace Ejemplo {
    class Hija: Madre {
        //Constructor
        public Hija() {
            Console.WriteLine("Constructor de la clase hija");
        }
		
        public new void Mostrar() {
            base.Mostrar(); //Llama al método de la clase madre
            Console.WriteLine("Mostrar en Hija");
        }
    }
}
