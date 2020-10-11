using System;

namespace Ejemplo {
    //Esta es una clase propia con sus atributos y métodos (encapsulación)
    class MiClase {
        //Atributos privados. Un uso de los getters y setters
        private int edad;

        //Puede validar el dato de inicialización
        public int Edad {
            get {
                return edad;
            }
            set {
                if (value < 0)
                    Console.WriteLine("La edad no debe ser negativa");
                else
                    edad = value;
            }
        }

    }
}
