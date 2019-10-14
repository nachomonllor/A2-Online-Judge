https://a2oj.com/p?ID=164
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
                int r = int.Parse(Console.ReadLine());
                Console.WriteLine((2 * Math.PI * r).ToString("0.00"));

            }
            Console.ReadLine();
        }
    }
}
