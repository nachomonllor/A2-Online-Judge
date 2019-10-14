https://a2oj.com/p?ID=132
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

            while (t-- > 0)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                var da = new Dictionary<char, int>();
                foreach (char ch in a)
                {
                    if (da.ContainsKey(ch))
                    {
                        da[ch]++;
                    }
                    else
                    {
                        da[ch] = 1;
                    }
                }

                var db = new Dictionary<char, int>();
                foreach (char ch in b)
                {
                    if (db.ContainsKey(ch))
                    {
                        db[ch]++;
                    }
                    else
                    {
                        db[ch] = 1;
                    }
                }

                int ans = 0;
                //cuento los que estan en comun (en da y en db), 
                //y calculo su valor absoluto que es por si uno tiene mas 
                //que otro, ej da tenga 3 ‘a’ y db tenga 7 ‘a’, 
                //en ese caso hay que borrar 4 ‘a’, 
                //y 4 es el valor absoluto de la diferencia 
                //entre el contador de ‘a’ en el primer string
                //y el contador de ‘a’del segundo string
                foreach (KeyValuePair<char, int> kvp in da)
                {
                    if (db.ContainsKey(kvp.Key))
                    {
                        ans += Math.Abs(kvp.Value - db[kvp.Key]);
                    }
                    else //si el carácter no esta en b, como no son comunes, los cuento como parte de los que hay que borrar 
                    {
                        ans += kvp.Value;
                    }

                }

                //ahora recorro el diccionario  del segundo string
                //si el carácter no esta en el diccio del primer   string,
                //o sea no son caracteres que estan en ambos strings, 
                //por lo tanto los cuento como caracteres a borrar
                foreach (KeyValuePair<char, int> kvp in db)
                {
                    if (!da.ContainsKey(kvp.Key))
                    {
                        ans += kvp.Value;
                    }

                }

                Console.WriteLine(ans);

            }


        }
    }
}

