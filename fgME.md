using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fghj
{
    class Program
    {
        public static void Main(string[] args)
        {
            int NUM1, NUM2;
            double RESUL;
            string linea;
            Console.Write("valor a : "); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("valor b : "); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            RESUL = (NUM1 + NUM2) * (NUM1 - NUM2);
            Console.WriteLine();
            Console.WriteLine("El Resultado es " + RESUL);
            Console.ReadLine();

        }
    }
}
