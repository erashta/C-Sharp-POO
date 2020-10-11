using System;

namespace Ejemplo {
	//Implementa de varios Interface
    class Circulo : ICalculos, IMuestra {
        public double Radio { get; set; }

        public Circulo(double Radio) {
            this.Radio = Radio;
        }

        //Implementa los métodos señalados por la interface
        public double AreaFigura() {
            return Math.PI * Radio * Radio;
        }

        public double PerimetroFigura() {
            return 2 * Math.PI * Radio;
        }

        public void ImprimeArea() {
            Console.WriteLine("Área del círculo: " + AreaFigura().ToString());
        }

        public void ImprimePerimetro() {
            Console.WriteLine("Perímetro del círculo: " + PerimetroFigura().ToString());
        }
    }
}
