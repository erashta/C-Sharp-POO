namespace Ejemplo {
	//Esta clase debe implementar lo que dice la interface
    class Cuadrado : IMetodosRequeridos {
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
    }
}
