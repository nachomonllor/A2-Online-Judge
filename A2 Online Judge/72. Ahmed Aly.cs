https://a2oj.com/p?ID=72

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
                string ec = Console.ReadLine();

                string[] partes = ec.Split('+', '-', '=');

                string ans = "NO";

                if (ec.Contains('+'))
                {
                    if (int.Parse(partes[0].Trim()) + int.Parse(partes[1].Trim()) == int.Parse(partes[2].Trim()))
                    {
                        ans = "YES";
                    }
                }
                else if (ec.Contains('-'))
                {
                    if (int.Parse(partes[0].Trim()) - int.Parse(partes[1].Trim()) == int.Parse(partes[2].Trim()))
                    {
                        ans = "YES";
                    }
                }

                Console.WriteLine("Case {0}: {1}", test++, ans);

            }

            Console.ReadLine();
        }
    }
}

