using System;

namespace Calculadora_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num1 = 0; double num2 = 0;
		Principio:
			Console.WriteLine("Inserta el primer número");
			Console.WriteLine("-------------------------");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Inserta el segundo número");
			Console.WriteLine("-------------------------");
			num2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ahora elige la operación de esta lista que quieras");
			Console.WriteLine("\ta - Suma");
			Console.WriteLine("\tb - Resta");
			Console.WriteLine("\tc - Multiplicación");
			Console.WriteLine("\td - División");
		Seleccion1:

			Console.Write("Elige entre a,b,c,d:   ");
			switch (Console.ReadLine())
			{
				case "a":
					Console.WriteLine($"El resultado es: {num1} + {num2} = " + (num1 + num2));
					break;
				case "b":
					Console.WriteLine($"El resultado es: {num1} - {num2} = " + (num1 - num2));
					break;
				case "c":
					Console.WriteLine($"El resultado es: {num1} * {num2} = " + (num1 * num2));
					break;
				case "d":
					while (num2 == 0)
					{
						Console.WriteLine("No pongas cero que no se puede dividir entre cero tonto");
						num2 = Convert.ToDouble(Console.ReadLine());
					}
					break;
				default:
				    Console.WriteLine("Opción invalida");
					goto Seleccion1;
					break;
			}
		Seleccion2:
			Console.WriteLine("¿Quieres hacer otra operación?");
			Console.WriteLine("Y(Si)/N(No)");
			switch (Console.ReadLine())
            {
				case "Y":
					goto Principio;
					break;
				case "N":
					goto Final;
					break;
				default:
					goto Seleccion2;
					break;
            }
		Final:
			Console.ReadKey();
			//Espero que funcione
			//En efecto, no funciona
			//Nota para mí WriteLine es sensible a mayusculas y la L tambien tiene que serlo
			//Nota 2, no borres } sin querer
		}
	}
}
