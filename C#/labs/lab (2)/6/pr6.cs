using System;
using System.Linq;

namespace _6
{
    class pr6
    {
        static void Main(string[] args)
        {
            Console.Write("Array = ");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start, len = 1,bestStart = 0,bestLen = 0;
            start = 0;
            bool k = true,kq = true;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[start] == arr[i])
                {
                    len++;
                }
                else
                {
                    kq = false;
                    
                    if (k)
                    {
                        bestLen = len;
                        bestStart = start;
                        k = false;
                    }
                    else
                    if(len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                    start = i;
                    len = 1;
                }                 
            }
            if(kq)
            {
                bestLen = len;
                bestStart = start;
            }
            else
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = start;
            }

            int q = bestStart;
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(arr[q] + " ");
                q++;
            }

        }
    }
}
