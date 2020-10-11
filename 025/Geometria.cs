using System;

namespace Ejemplo {
    //Clase con métodos estáticos
    class Geometria {
        //Estos métodos estáticos pueden ser usados sin instanciar la clase
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

        //Este método requiere instanciar la clase
        public double VolumenEsfera(double radio) {
            return 4 / 3 * Math.PI * Math.Pow(radio, 3);
        }
    }
}
