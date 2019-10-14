https://a2oj.com/p?ID=139
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
                string s = Console.ReadLine();

                int i = 0;

                char actual = s[i];

                string ans = "";

                while (i < s.Length)
                {
                    int cont = 0;
                    while (i<s.Length && s[i] == actual)
                    {
                        i++;
                        cont++;
                    }
                    ans += actual + cont.ToString();
                    if (i < s.Length)
                    {
                        actual = s[i];
                    }
                }

                Console.WriteLine(ans);
            }

            Console.ReadLine();
        }
    }
}
