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

		//Método que permite copiar un objeto
		public MiClase CopiarObjeto() {
			MiClase copia = new MiClase(Numero, Letra, Cadena, Valor);
			return copia;
		}

		//Otra forma de definir atributos con los getters y setters
		public int Numero { get; set; }
		public char Letra { get; set; }
		public string Cadena { get; set; }
		public double Valor { get; set; }
	}
}
