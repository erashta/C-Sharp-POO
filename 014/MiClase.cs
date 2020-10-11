using System;

namespace Ejemplo {
    class MiClase {
        //Constructor
        public MiClase() {
            //Llama a otros métodos
            MetodoA();
            MetodoB();
        }

        public void MetodoA() {
            Console.WriteLine("Ha llamado el método A");
        }

        private void MetodoB() {
            Console.WriteLine("Ha llamado el método B");
        }
    }
}
