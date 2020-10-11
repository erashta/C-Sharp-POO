namespace Ejemplo {
	//Esta es una clase propia con sus atributos y métodos (encapsulación)
	class MiClase {
		//Atributos privados
		private int numero;
		private char letra;
		private string cadena;
		private double valor;

		//Atributos públicos (no recomendado)
		public int acumula;
		public char caracter;

		//Métodos privados
		private double Maximo(double numA, double numB, double numC) {
			double max = numA;
			if (max < numB) max = numB;
			if (max < numC) max = numC;
			return max;
		}

		//Métodos públicos
		public double CalculaPromedio(double numA, double numB, double numC) {
			return (numA + numB + numC) / 3;
		}
	}
}
