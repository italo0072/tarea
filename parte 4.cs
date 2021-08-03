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
            double NUM1;
            double RESUL;
            string linea;
            Console.Write("grados ºC : "); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            RESUL = (NUM1 * 9 / 5) + 32;
            Console.WriteLine();
            Console.WriteLine("El Resultado es " + RESUL + "ºF");
            Console.ReadLine();

        }
    }
}
