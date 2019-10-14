https://a2oj.com/p?ID=186

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

                string mensaje = Console.ReadLine(); // "HPC PJVYMIY";
                string asig = Console.ReadLine(); // "BLMRGJIASOPZEFDCKWYHUNXQTV";

                var dic = new Dictionary<char, char>();

                for (int i = 'A'; i <= 'Z'; i++)
                {
                    dic[(char)i] = asig[i - 'A'];
                }

                string ans = "";
                foreach (char ch in mensaje)
                {
                    if (ch != ' ')
                    {
                        ans += dic[ch];
                    }
                    else
                    {
                        ans += " ";
                    }
                }
                Console.WriteLine("{0} {1}", test++, ans);
            }

            Console.ReadLine();
        }
    }
}
