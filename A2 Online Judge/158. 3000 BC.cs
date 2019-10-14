https://a2oj.com/p?ID=158
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
           // string message = "h";

            int t = int.Parse(Console.ReadLine());
            int k;

            while (t-- > 0)
            {
                //string input = "15 Tomorrow, we will invade Sparta!"; // Console.ReadLine();
                string input =  Console.ReadLine();

                string sizeString = "";
                k = 0;
                while (k < input.Length && input[k] != ' ')
                {
                    sizeString += input[k];
                    k++;
                }
                k++;

                int size = int.Parse(sizeString);
                string message = input.Substring(k, input.Length - k);
                //int size = 6;
                //string message = "Tomorrow, we will invade Sparta!";
                char[,] matriz = new char[size, size];

                  k = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (k < message.Length)
                        {
                            matriz[i, j] = message[k];
                            k++;
                        }
                        else
                        {
                            matriz[i, j] = '*';
                        }
                    }
                }

                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        Console.Write(matriz[i, j] + " ");
                //    }
                //    Console.WriteLine();
                //}


                for (int i = 0; i < size; i++)
                {
                    int fila = 0, col = i;
                    while (fila < size && col >= 0)
                    {
                        Console.Write(matriz[fila, col]);
                        fila++;
                        col--;
                    }

                }

                for (int j = 1; j < size; j++)
                {
                    int fila = j, col = size - 1;
                    while (fila < size && col >= 0)
                    {
                        Console.Write(matriz[fila, col]);
                        fila++;
                        col--;
                    }
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}


