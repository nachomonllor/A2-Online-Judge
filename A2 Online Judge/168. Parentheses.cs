https://a2oj.com/p?ID=168

http://www.geeksforgeeks.org/find-the-next-lexicographically-greater-word-than-a-given-word/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool isValid(string s)
        {
            string abierto = "(";
            string cerrado = ")";
            Stack<char> pila = new Stack<char>();
            bool balanceado = true;

            for (int i = 0; i < s.Length && balanceado; i++)
            {
                char actual = s[i];

                if (abierto.IndexOf(actual) > -1)
                {
                    pila.Push(actual);
                }
                else if (cerrado.IndexOf(actual) > -1)
                {
                    balanceado = (!(pila.Count == 0))
                    && cerrado.IndexOf(actual) == abierto.IndexOf(pila.Pop());
                }
            }
            return balanceado && pila.Count == 0;
        }


        static void swap(ref char a,ref char b)
        {
            char temp = a;
            a = b;
            b =temp;
        }
        static void rev(ref char[] s,int l,int r)
        {
            while(l<r)
                swap( ref s[l++], ref s[r--]);
        }

        static int bsearch(char[]s, int l, int r, int key)
        {
            int index = -1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (s[mid] <= key)
                    r = mid - 1;
                else
                {
                    l = mid + 1;
                    if (index == -1 || s[index] <= s[mid])
                        index = mid;
                }
            }
            return index;
        }

        static bool nextpermutation(char[] s)
        {
            int len = s.Length, i = len - 2;
            while (i >= 0 && s[i] >= s[i + 1])
                --i;
            if (i < 0)
                return false;
            else
            {
                int index = bsearch(s, i + 1, len - 1, s[i]);
                swap( ref s[i], ref s[index]);
                rev(ref s, i + 1, len - 1);
                return true;
            }
        }
        static void print(char[] s)
        {
            foreach (char ch in s)
            {
                Console.Write(ch);
            }
        }


        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());

            string s = "";

            for (int i = 0; i < n; i++)
            {
                s += "(";
            }
            for (int i = 0; i < n; i++)
            {
                s += ")";
            }

            char[] permutar = s.ToCharArray();
            print(permutar);
            Console.WriteLine();
            while (nextpermutation(permutar))
            {
                if (isValid(new string(permutar)))
                {
                    print(permutar);
                    Console.WriteLine();
                }
            }


      
            Console.ReadLine();
        }
    }
}
