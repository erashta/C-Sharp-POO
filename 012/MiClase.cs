using System;

namespace Ejemplo {
    class MiClase {
        private int valor;
        private string cadena;
        private double costo;
        public MiClase() {
            Console.WriteLine("Constructor por defecto");
        }

        public MiClase(int valor) {
            this.valor = valor;
            this.cadena = "por defecto";
            this.costo = 0;
            Console.WriteLine("Constructor B");
        }

        public MiClase(string cadena, int valor) {
            this.cadena = cadena;
            this.valor = valor;
            this.costo = 0;
            Console.WriteLine("Tercer Constructor");
        }

        public MiClase(double costo, int valor) {
            this.cadena = "por defecto";
            this.costo = costo;
            this.valor = valor;
            Console.WriteLine("El cuarto constructor");
        }

        public MiClase(string cadena, double costo, int valor) {
            this.cadena = cadena;
            this.costo = costo;
            this.valor = valor;
            Console.WriteLine("Quinto constructor");
        }
    }
}
