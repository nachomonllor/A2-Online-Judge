https://a2oj.com/p?ID=148
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

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "***")
                {
                    break;
                }

                List<int> numeros = new List<int>();
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsNumber(line[i]))
                    {
                        numeros.Add(int.Parse(line[i].ToString()));
                    }
                }

                numeros.Reverse();

                foreach (int elem in numeros)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
