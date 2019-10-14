https://a2oj.com/p?ID=184
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        static Dictionary<char, int> CargarDiccionario(string s)
        {
            var d = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (d.ContainsKey(ch))
                {
                    d[ch]++;
                }
                else
                {
                    d[ch] = 1;
                }
            }
            return d;
        }


        static void Main(string[] args)
        {
            int test = 1;

            while (true)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                if (a == "END" && b == "END")
                {
                    break;
                }
                var da = CargarDiccionario(a);
                var db = CargarDiccionario(b);

                string ans = "same";

                foreach (KeyValuePair<char, int> kvp in da)
                {
                    if (!db.ContainsKey(kvp.Key))
                    {
                        ans = "different";
                        break;
                    }
                    else
                    {
                        if (kvp.Value != db[kvp.Key])
                        {
                            ans = "different";
                            break;
                        }
                    }
                }

                Console.WriteLine("Case {0}: {1}", test++, ans);

            }
            Console.ReadLine();
        }
    }
}
