https://a2oj.com/p?ID=17
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
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);

                string[] elems = Console.ReadLine().Split(' ');
                int[] tipos = Array.ConvertAll(elems, e => int.Parse(e));

                int ans = 0;
                for (int i = 0; i < n; i++)
                {
                    ans += tipos[i] / k;
                }
                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }

    }
}
