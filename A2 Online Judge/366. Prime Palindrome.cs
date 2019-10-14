https://a2oj.com/p?ID=366

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static String nextPal(String s)
        {

            // scanf("%s",str);
            char[] str = s.ToCharArray();

            String ans = "";

            int lenght = str.Length; // strlen(str);

            int j = lenght;
            int i = -1;

            while (++i <= --j)
            {
                if (str[i] != str[j])
                {
                    break;
                }
            }

            if (j < i)
            {
                /*   Number is palindrome   */

                if (lenght % 2 != 0)
                {
                    /* odd lenght  */

                    if (str[lenght / 2] < '9')
                    {
                        /* check the middle one not 9 */

                        str[lenght / 2]++;


                        //ans += str;
                        ans += new String(str);

                    }

                    else
                    {
                        str[lenght / 2] = '0';

                        i = lenght / 2 - 1;
                        j = lenght / 2 + 1;

                        while (i >= 0)
                        {

                            if (str[i] < '9')
                            {
                                str[i]++;
                                str[j]++;
                                break;
                            }

                            else
                            {
                                str[i] = str[j] = '0';
                            }

                            i--;
                            j++;
                        }

                        if (i < 0)
                        {
                            //   printf("1");
                            ans += "1";

                            i = lenght;
                            while (--i > 0)
                            {
                                //     printf("0");
                                ans += "0";
                            }

                            //  printf("1\n");
                            ans += "1";
                        }

                        else
                        {

                            //  printf("%s\n",str);
                            // ans += str;
                            ans += new String(str);

                        }
                    }
                }

                else
                {
                    /*  even lenght  */

                    i = lenght / 2 - 1;
                    j = lenght / 2;

                    while (i >= 0)
                    {

                        if (str[i] < '9')
                        {
                            str[i]++;
                            str[j]++;
                            break;
                        }

                        else
                        {
                            str[i] = str[j] = '0';
                        }

                        i--;
                        j++;
                    }

                    if (i < 0)
                    {
                        //   printf("1");
                        ans += "1";

                        i = lenght;
                        while (--i > 0)
                        {
                            //     printf("0");
                            ans += "0";
                        }

                        //  printf("1\n");
                        ans += "1";
                    }

                    else
                    {

                        // printf("%s\n",str);
                        //ans += str;
                        ans += new String(str);

                    }
                }
            }

            else
            {
                if (lenght % 2 != 0)
                {
                    i = lenght / 2 - 1;
                    j = lenght / 2 + 1;
                }

                else
                {
                    i = lenght / 2 - 1;
                    j = lenght / 2;
                }

                int flag = 0;

                while (i >= 0)
                {

                    if (str[i] - str[j] > 0)
                    {
                        flag = 1;
                        break;
                    }

                    else if (str[i] - str[j] < 0)
                    {
                        flag = 2;
                        break;
                    }

                    i--;
                    j++;
                }

                if (lenght % 2 != 0)
                {
                    i = lenght / 2 - 1;
                    j = lenght / 2 + 1;
                }

                else
                {
                    i = lenght / 2 - 1;
                    j = lenght / 2;
                }

                if (flag == 1)
                {    /*  line 1*/
                    while (i >= 0)
                    {
                        str[j] = str[i];

                        i--;
                        j++;
                    }
                }

                else if (flag == 2 && lenght % 2 != 0 && str[lenght / 2] < '9')
                {    /* line 2*/
                    str[lenght / 2]++;

                    i = lenght / 2 - 1;
                    j = lenght / 2 + 1;

                    while (i >= 0)
                    {
                        str[j] = str[i];
                        i--;
                        j++;
                    }
                }

                else
                {                          /* line 3   */

                    if (lenght % 2 != 0)
                    {
                        str[lenght / 2] = '0';
                    }

                    while (i >= 0)
                    {
                        if (str[i] < '9')
                        {
                            str[i]++;
                            str[j] = str[i];
                            break;
                        }

                        else
                        {
                            str[i] = str[j] = '0';
                        }
                        i--;
                        j++;
                    }

                    while (i >= 0)
                    {
                        str[j] = str[i];

                        i--;
                        j++;
                    }
                }

                // printf("%s\n",str);
                //ans += str;

                ans += new String(str);

            }

            return ans;
        }

        static bool esPrimo(long n)
        {

            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            long sqr = (long)Math.Sqrt(n);
            for (long i = 3; i <= sqr; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(nextPal("1000000000000000000000000000000000"));

            long p = long.Parse(Console.ReadLine());
            //Console.WriteLine(long.MaxValue);
            if (esPrimo(p))
            {
                char[] rev = p.ToString().ToCharArray();
                Array.Reverse(rev);
                if (p.ToString() == new string(rev))
                {
                    Console.WriteLine(p);
                }
            }
            else
            {
                string np = nextPal(p.ToString());
                while (true)
                {
                    if (esPrimo(long.Parse(np)))
                    {
                        Console.WriteLine(np);
                        break;
                    }
                    np = nextPal(np);
                }

            }

            Console.ReadLine();

        }
    }
}


