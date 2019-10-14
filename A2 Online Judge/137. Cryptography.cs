https://a2oj.com/p?ID=137
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string Caesar(string text, int shift)
        {
            string alfab = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

            if (shift >= 26)
            {
                shift = shift % 26;
            }

            string ans = "";
            for (int i = 0; i < text.Length; i++)
            {

                // ans +=  (alfab.IndexOf(text[i]) + shift).ToString().ToUpper();
                //ans += alfab[ text.IndexOf(i)+shift];

                int indalfab = alfab.IndexOf(char.ToLower( text[i]));

                if (char.IsLower(text[i]))
                {
                    ans += alfab[indalfab + shift].ToString().ToUpper();
                }
                else
                {
                    ans += alfab[indalfab + shift].ToString().ToLower();
                }
            }

            return ans;
        }


        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] input =   Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);

                string[] pals =   Console.ReadLine().Split(' ');
                string ans = "";
                int i;
                for ( i = 0; i < pals.Length - 1; i++)
                {
                    ans += Caesar(pals[i].Trim(), m) + " ";
                }
                ans += Caesar(pals[i].Trim(), m);

                Console.WriteLine(ans);
            }
            Console.ReadLine();
        }
    }
}

