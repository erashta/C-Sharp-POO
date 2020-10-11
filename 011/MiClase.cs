namespace Ejemplo {
    //Esta es una clase propia con sus atributos y métodos (encapsulación)
    class MiClase {
        //Un constructor
        public MiClase(int Numero, char Letra, string Cadena, double Valor) {
            this.Numero = Numero; //Se asigna así this.atributo = valor parámetro
            this.Letra = Letra;
            this.Cadena = Cadena;
            this.Valor = Valor;
        }

        //Otra forma de definir atributos con los getters y setters
        public int Numero { get; set; }
        public char Letra { get; set; }
        public string Cadena { get; set; }
        public double Valor { get; set; }
    }
}
