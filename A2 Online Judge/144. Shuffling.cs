https://a2oj.com/p?ID=144
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
                string[] elem = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(elem, e => int.Parse(e));

                int[] copia = new int[arr.Length];
                Array.Copy(arr, copia, arr.Length);
                Array.Sort(copia);

                int ans = 0;
                for (int i = 0; i < copia.Length; i++)
                {
                    if (arr[i] == copia[i])
                    {
                        ans++;
                    }
                }
                Console.WriteLine(ans);
            }
            Console.ReadLine();
        }
    }
}
