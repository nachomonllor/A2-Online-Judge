https://a2oj.com/p?ID=179

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
                long x = long.Parse(Console.ReadLine());

                for (long i = 1; ; i++)
                {
                    if ((x * i) % 7 == 0)
                    {
                        Console.WriteLine(x * i);
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
