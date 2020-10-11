namespace Ejemplo {
	//Esta es una clase propia con sus atributos y métodos (encapsulación)
	class MiClase {
		//Atributos privados
		private int numero;
		private char letra;
		private string cadena;
		private double valor;

		//Los getters y setters
		public int Numero { get => numero; set => numero = value; }
		public char Letra { get => letra; set => letra = value; }
		public string Cadena { get => cadena; set => cadena = value; }
		public double Valor { get => valor; set => valor = value; }
	}
}
