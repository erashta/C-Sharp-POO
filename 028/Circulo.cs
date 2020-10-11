using System;

namespace Ejemplo {
	//Esta clase debe implementar lo que dice la interface
    class Circulo : IMetodosRequeridos {
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
    }
}
