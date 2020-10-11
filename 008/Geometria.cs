using System;

namespace Ejemplo {
    class Geometria {
        //Calcula el área del círculo
        public double Area(double radio) {
            return Math.PI * Math.Pow(radio, 2);
        }

        //Calcula el área del rectángulo
        public double Area(double baseR, double alturaR) {
            return baseR * alturaR;
        }

        //Calcula el área del triángulo
        public double Area(double ladoA, double ladoB, double ladoC) {
            double S = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(S * (S - ladoA) * (S - ladoB) * (S - ladoC));
        }
    }
}
