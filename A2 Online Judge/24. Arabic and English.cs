https://a2oj.com/p?ID=24
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
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                string s = Console.ReadLine();

                //string s = "# #### ### abc ##";
                //string s = "# #### ### abc";
                //string s = "abc ### ##";
                //string s = "### abcdefghij";
                //string s = "# ### #";
                //string s = "abcd";

                int i = 0;
                while (i < s.Length && !char.IsLetter(s[i]))
                {
                    i++;
                }
                int j = s.Length - 1;
                while (j >= 0 && !char.IsLetter(s[j]))
                {
                    j--;
                }

                if (j >= 0 && i < s.Length)
                {
                    //Console.WriteLine(s.Substring(i, j - i + 1));

                    string a = s.Substring(j + 1, s.Length - j - 1).Trim();
                    string b = s.Substring(i, j - i + 1).Trim();
                    string c = s.Substring(0, i).Trim();

                    Console.Write(a);
                    if (a.Length > 0)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(b);
                    if (b.Length > 0)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(c);

                }
                else
                {
                    Console.Write(s);
                }

                Console.WriteLine();

            }

        }
    }
}

