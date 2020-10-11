using System;

namespace Ejemplo {
	//Hereda de Madre e implementa de IMetodos e IProcedimientos
    class Hija : Madre, IMetodos, IProcedimientos {
        public void Mensaje() {
            Console.WriteLine("En clase hija");
        }

        public void MetodoA() {
            Console.WriteLine("En MetodoA");
        }

        public void MetodoB() {
            Console.WriteLine("En MetodoB");
        }

        public void ProcedimientoA() {
            Console.WriteLine("En ProcedimientoA");
        }

        public void ProcedimientoB() {
            Console.WriteLine("En ProcedimientoB");
        }
    }
}
