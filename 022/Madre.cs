using System;

namespace Ejemplo {
    class Madre : Abuela {
        //Constructor
        public Madre() {
            Console.WriteLine("Constructor de la clase madre");
        }

        public new void Mostrar() {
            base.Mostrar(); //Llama al método de la clase abuela
            Console.WriteLine("Mostrar en Madre");
        }
    }
}
