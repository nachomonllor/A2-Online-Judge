https://a2oj.com/p?ID=150
TOMAR EN CUENTA QUE CADA 60 NUMEROS SE REPITE EL MISMO DIGITO, 
LEER: 
http://www.johndcook.com/blog/2015/08/04/last-digits-fibonacci-numbers/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }

                int n = int.Parse(input);
                int[] ultDig = { 1, 1, 2, 3, 5, 8, 3, 1, 4, 5, 9, 4, 3, 7, 0, 7, 7, 4, 1, 5, 6, 1, 7, 8, 5, 3, 8, 1, 9, 0, 9, 9, 8, 7, 5, 2, 7, 9, 6, 5, 1, 6, 7, 3, 0, 3, 3, 6, 9, 5, 4, 9, 3, 2, 5, 7, 2, 9, 1, 0, 1 };
                //Console.WriteLine(ultDig.Length);
                if (n % 60 == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(ultDig[(n % 60) - 1]);
                }
            }
            Console.ReadLine();
        }
    }
}
