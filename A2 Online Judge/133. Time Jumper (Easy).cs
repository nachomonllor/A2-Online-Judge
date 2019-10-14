https://a2oj.com/p?ID=133
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static List<List<int>> Powerset(int[] nums)
        {
            List<List<int>> ps = new List<List<int>>();
            ps.Add(new List<int>());   // add the empty set

            // for every item in the original list
            foreach (int item in nums)
            {
                List<List<int>> newPs = new List<List<int>>();

                foreach (List<int> subset in ps)
                {
                    // copy all of the current powerset's subsets
                    newPs.Add(subset);

                    // plus the subsets appended with the current item
                    List<int> newSubset = new List<int>(subset);
                    newSubset.Add(item);
                    newPs.Add(newSubset);
                }

                // powerset is now powerset of list.subList(0, list.indexOf(item)+1)
                ps = newPs;
            }

            return ps;

        }



        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int y = int.Parse(input[0]);
                int n = int.Parse(input[1]);
                string[] elems = Console.ReadLine().Split(' ');
                int[] stones = Array.ConvertAll(elems, e => int.Parse(e));

                List<List<int>> ps = Powerset(stones);

                List<int> answer = new List<int>();
                foreach (List<int> lista in ps)
                {
                    int sum = lista.ToArray().Sum();
                    if (sum > 0 && !answer.Contains(y+sum))
                    {
                        answer.Add(y + sum);
                    }
                }

                answer.Sort();
                foreach (int e in answer)
                {
                    Console.WriteLine(e);
                }
            }

            Console.ReadLine();
        }
    }
}

