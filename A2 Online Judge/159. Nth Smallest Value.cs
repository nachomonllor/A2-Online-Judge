https://a2oj.com/p?ID=159

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
                int[] arr = Array.ConvertAll(input, e => int.Parse(e));

                Array.Sort(arr);
                Console.WriteLine(arr[1]);
            }

            Console.ReadLine();
        }
    }
}

