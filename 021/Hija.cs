using System;

namespace Ejemplo {
    class Hija: Madre {
        //Constructor
        public Hija() {
            Console.WriteLine("Constructor de la clase hija");
        }
        public new void Mostrar() {
            Console.WriteLine("Mostrar en Hija");
        }
    }
}
