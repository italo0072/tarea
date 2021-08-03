using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fghj
{
    class Program
    {
		public static void Main()
		{
		

			Console.WriteLine("Introduzca el primer numero");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Introduzca el segundo numero");
			int num2 = int.Parse(Console.ReadLine());
			if (num2 == 0)
			{
				Console.WriteLine("Error, no se puede dividir entre cero");
			}

			else
			{
				int resultado = num1 / num2;
				Console.WriteLine("El resultado es " + resultado);
			}

			Console.ReadLine();
		}
	}
}
