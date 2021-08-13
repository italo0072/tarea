using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directorio
{
    class Program
    {
        static void Main(string[] args)
        
            { 
            Dictionary<string, string> famili = new Dictionary<string, string>();

            famili.Add("Magali Guevara", "26");
            famili.Add("Dayana Guevara", "21");
            famili.Add("Teresa Garcia", "56");
            famili.Add("italo ayala", "49");


                foreach (KeyValuePair<string , string > employee in famili)
                {
                    Console.WriteLine("Nombre: {0}, Edad:  {1}  años ", employee.Key, employee.Value);
                }

            var dic = famili.Keys.ToList();
            dic.Sort();

            Console.WriteLine("Elementos en el dicionario: {0} ", famili.Count);
                
            Console.ReadKey();


            }







        






    }

}

