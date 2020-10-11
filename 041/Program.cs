//Patrón: Abstract Factory
using System;

namespace PatronDiseno {
	class Program {
		static void Main() {
			//Trae una determinada fábrica en este caso de FIGURA 
			FabricaAbstracta fabricaFiguras = ProductorDeFabricas.GetFabrica("FIGURA");

			//Obtenida la fábrica, se solicita un tipo de objeto de esa fábrica
			IFigura figura1 = fabricaFiguras.GetFigura("CIRCULO");

			//Llama un método de ese objeto dado por la fábrica en particular
			figura1.Dibujar();

			//Obtenida la fábrica, se solicita un tipo de objeto de esa fábrica
			IFigura figura2 = fabricaFiguras.GetFigura("RECTANGULO");

			//Llama un método de ese objeto dado por la fábrica en particular
			figura2.Dibujar();

			//Obtenida la fábrica, se solicita un tipo de objeto de esa fábrica 
			IFigura figura3 = fabricaFiguras.GetFigura("TRIANGULO");

			//Llama un método de ese objeto dado por la fábrica en particular
			figura3.Dibujar();

			//Trae una determinada fábrica en este caso de COLOR
			FabricaAbstracta FabricaColores = ProductorDeFabricas.GetFabrica("COLOR");

			//Obtenida la fábrica, se solicita un tipo de objeto de esa fábrica
			IColor color1 = FabricaColores.GetColor("ROJO");

			//Llama un método de ese objeto dado por la fábrica en particular
			color1.Rellenar();

			//Obtenida la fábrica, se solicita un tipo de objeto de esa fábrica
			IColor color2 = FabricaColores.GetColor("VERDE");

			//Llama un método de ese objeto dado por la fábrica en particular
			color2.Rellenar();

			//Obtenida la fábrica, se solicita un tipo de objeto de esa fábrica
			IColor color3 = FabricaColores.GetColor("AZUL");

			//Llama un método de ese objeto dado por la fábrica en particular
			color3.Rellenar();

			Console.ReadKey();
		}
	}
}
