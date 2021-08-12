using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xf
{
    class Program
    {
        static void Main(string[] args)
        {
           
            loops();

            Console.ReadLine();
        }

        ///bucles
        public static void loops()
        {
            int[] numbers = new int[10];
           double  sumatoria = 0;
           
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("escribir el valor paraelementos {0}: ", x);
                    numbers[x] = Convert.ToInt32(Console.ReadLine());

            }

            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);


            Console.WriteLine("IMPRIME ELEMENTOS CON FOR - ARREGLO ORDENADO ");
            Array.Sort(numbers);
            for (int j = 0; j < numbers.Length; j++)
            {
                // sumar los valores del array
               
                sumatoria = sumatoria + numbers[j];
                Console.WriteLine(sumatoria);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH - ARREGLADO INVERTIDO");
            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("el promedio es de :  {0} ", sumatoria/(numbers.Length) );

        }

    }

