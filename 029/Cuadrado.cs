using System;

namespace Ejemplo {
    class Cuadrado : ICalculos, IMuestra {
        public double Lado { get; set; }
        
        public Cuadrado(double Lado) {
            this.Lado = Lado;
        }

        //Implementa los métodos señalados por la interface
        public double AreaFigura() {
            return Lado * Lado;
        }

        public double PerimetroFigura() {
            return 4 * Lado;
        }

        public void ImprimeArea() {
            Console.WriteLine("Área del cuadrado: " + AreaFigura().ToString());
        }

        public void ImprimePerimetro() {
            Console.WriteLine("Perímetro del cuadrado: " + PerimetroFigura().ToString());
        }
    }
}
