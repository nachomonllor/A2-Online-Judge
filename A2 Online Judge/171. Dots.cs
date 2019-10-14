https://a2oj.com/p?ID=171
USE LA FORMULA DE NUMERO TRIANGULAR QUE ES  T(N)=N*(N+1)/2
LUEGO USE LA FORMULA –b +- sqrt(b^2-4ac)/2ª para sacar el valor de N y saber que término es, por ejemplo T(4) = 10, agarro el 10 lo reemplazo en la formula 4 = N*(N+1)/2 Y DESPEJO N, que es el termino al que le corresponde el 10.
Por ultimo tomo el termino n, y lo reemplazo en la formula, ej si me da 4, reemplazo el 4 en 10 = 4*(4+1)/2 si me da 10 imprimo “Yes”, de lo contrario imprimo “No”
https://es.wikipedia.org/wiki/N%C3%BAmero_triangular



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

                int x = int.Parse(Console.ReadLine());
		    

    //res es sacado de –b +- sqrt(b^2-4ac)/2a
                double res = -1 + (Math.Sqrt(1 + 8 * x) / 2);

int n = (int)Math.Ceiling(res);//REDONDEO PARA ARRIBA PORQUE  DA EL TERMINO CON DECIMAL	

                if ((n * (n + 1)) / 2 == x)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}


