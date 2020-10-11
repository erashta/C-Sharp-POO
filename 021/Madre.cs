using System;

namespace Ejemplo {
    class Madre : Abuela {
        //Constructor
        public Madre() {
            Console.WriteLine("Constructor de la clase madre");
        }

        public new void Mostrar() {
            Console.WriteLine("Mostrar en Madre");
        }
    }
}
