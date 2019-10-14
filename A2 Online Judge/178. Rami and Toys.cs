https://a2oj.com/p?ID=178
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
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(' ');

                int[] arr = Array.ConvertAll(input, e => int.Parse(e));
                Console.WriteLine(arr.Max()); 
            }

            Console.ReadLine();
        }
    }
}
