using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fre
{
    class Program
    {
        static void Main(string[] args)
        {
           
            loops();

            Console.ReadLine();
        }

        public static void loops()
        {
            int[] numbers = new int[10];
            double sumatoria = 0;
           

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("escribir el valor paraelementos {0}: ", x);
                    numbers[x] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Sumatoria  ");
            Array.Sort(numbers);
            for (int j = 0; j < numbers.Length; j++)
            {
                sumatoria = sumatoria + numbers[j];
                Console.WriteLine(sumatoria);
            }

            

            Console.WriteLine("Su promedio es de :  {0} ", sumatoria/(numbers.Length));

        }

    }
}
