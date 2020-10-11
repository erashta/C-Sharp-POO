using System;

namespace Ejemplo {
    //Clase estática, no necesita instanciarse
    static class Geometria {
        //Todos los métodos deben ser static
        public static double AreaTriangulo(double baseT, double alturaT) {
            return baseT * alturaT / 2;
        }

        public static double AreaTriangulo(double ladoA, double ladoB, double ladoC) {
            double s = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
        }

        public static double AreaCirculo(double radio) {
            return  Math.PI*radio*radio;
        }
    }
}
