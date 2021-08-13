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
            Dictionary<string, string> employeelist = new Dictionary<string, string>();

            employeelist.Add("Jose Flores", "programador");
            employeelist.Add("Miranda Campos", "Gerente");
            employeelist.Add("Carmen Valladares", "arquitecta");

             Dictionary<string, int> students = new Dictionary<string, int>();
             students.Add("Jose Flores", 22);
             students.Add("Miranda Campos", 20);
            students.Add("Carmen Valladeres", 24);


                foreach (KeyValuePair<string , string > employee in employeelist )
                {
                    Console.WriteLine("clave: {0}, Valor:  {1}  ", employee.Key, employee.Value);
                }

            var dic = employeelist.Keys.ToList();
            dic.Sort();

            Console.WriteLine("Elementos en el dicionario: {0} ", employeelist.Count);
                
            Console.ReadKey();


            }





