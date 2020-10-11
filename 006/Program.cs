using System;

namespace Ejemplo {
	
	//Inicia la aplicación aquí
	class Program {
		static void Main() {
            //Instancia o crea un objeto de MiClase.
			//Otra forma de inicializar los atributos.
            MiClase Objeto = new MiClase {

                //Llama los setters
                Cadena = "Suini, Capuchina, Grisú, Milú, Sally, Vikingo",
                Numero = 7,
                Letra = 'R',
                Valor = 93.5
            };

            //Usa los getters
            char unaletra = Objeto.Letra;
			double unvalor = Objeto.Valor;
			string unacadena = Objeto.Cadena;
			int unnumero = Objeto.Numero;

			Console.WriteLine("Letra es: " + unaletra.ToString());
			Console.WriteLine("Valor es: " + unvalor.ToString());
			Console.WriteLine("Cadena es: " + unacadena);
			Console.WriteLine("Número es: " + unnumero.ToString());

			Console.ReadKey();
		}
	}
}
