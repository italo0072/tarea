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
            double NUM1, NUM2, NUM3;
            double RESUL1, RESUL2, RESUL3;
            double resultado;
            string linea;
            Console.Write("ingrese la nota 1: "); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("ingrese la nota 2 : "); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.Write("ingrese la nota 3: "); linea = Console.ReadLine();
            NUM3 = int.Parse(linea);
            RESUL1 = (NUM1 * 0.3);
            RESUL2 = (NUM2 * 0.35);
            RESUL3 = (NUM3 * 0.25);
            resultado = (RESUL1 + RESUL2 + RESUL3);
            Console.WriteLine();
            Console.WriteLine("la nota 1 ; " + RESUL1 + "  con porcentaje de 30%  "+ NUM1 +" sin el porcentaje ");
            Console.WriteLine();
            Console.WriteLine("la nota 2 ; " + RESUL2 + "  con porcentaje de 35%  " + NUM2 + " sin el porcentaje ");
            Console.WriteLine();
            Console.WriteLine("la nota 3 ; " + RESUL3 + "  con porcentaje de 25%  " + NUM3 + " sin el porcentaje ");
            Console.WriteLine();
            Console.WriteLine("la sumatoria de tonas seria :  " + resultado);

            Console.ReadLine();
