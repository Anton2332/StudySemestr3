using System;
using System.Linq;

namespace _8
{
    class pr8
    {
        static void Main(string[] args)
        {
            Console.Write("Array = ");
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int len = 0, n = number.Length, start, bestStart = 0, bestLen = 0;

            for (int i = 0; i < n; i++)
            {
                start = number[i];
                for (int j = 0; j < n; j++)
                {
                    if (start == number[j])
                    {
                        len++;
                    }
                }
                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
                len = 0;
            }

            //Console.WriteLine("The number " + bestStart + " is the most frequent (occurs " + bestLen + " times)");

            Console.WriteLine(bestStart);

        }
    }
}
