https://a2oj.com/p?ID=77
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int test = 1;

            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');

                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                //List<string> lineas = new List<string>();
                //lineas.Add("liked Badr's photo");
                //lineas.Add("liked Shakira's photo");
                //lineas.Add("liked Badr's photo");
                //lineas.Add("liked Fegla's photo");
                //lineas.Add("liked Shakira's photo");
                //lineas.Add("commented on Shakira's photo");


                var diccio = new Dictionary<string, int>();
                for (int i = 0; i < n; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    string nombre1 = s[s.Length - 2];
                    int index = nombre1.IndexOf('\'');//porque no me deja splitear el ‘ , entonces tomo el indice del ‘ y concateno todos los caracteres de nombre que hay detrás del ‘


                    string nombre = "";
                    for (int j = 0; j < index; j++)
                    {
                        nombre += nombre1[j];
                    }
				
				//cuento las veces que esta cada nombre 
                    if (diccio.ContainsKey(nombre))
                    {
                        diccio[nombre]++;
                    }
                    else
                    {
                        diccio[nombre] = 1;
                    }
                }

                Console.WriteLine("Case {0}:", test++);
                int cont = 0;
//y ordeno el diccionario por valor (la cantidad de  veces que esta cada nombre
                foreach (KeyValuePair<string, int> kvp in diccio.OrderBy(key => key.Value).Reverse())
                {

                    Console.WriteLine(kvp.Key);
                    cont++;
                    if (cont == k)
                    {
                        break;
                    }
                }

            }


            Console.ReadLine();
        }
    }
}
