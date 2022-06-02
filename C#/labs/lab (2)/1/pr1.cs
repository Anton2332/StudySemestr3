using System;
using System.Linq;

namespace _1
{
    class pr1
    {
        
        static void Main(string[] args)
        {
            int n,n2;

            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();
            if (words1.Length < words2.Length)
            {
                n = words1.Length;
            }
            else
            {
                n = words2.Length;
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (words1[i] == words2[i])
                {
                    k++;
                }
                else
                {
                    break;
                }
            }

            Array.Reverse(words1);
            Array.Reverse(words2);

            int k1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (words1[i] == words2[i])
                {
                    k1++;
                }
                else
                {
                    break;
                }
            }
            Array.Reverse(words1);
            Array.Reverse(words2);
            if (k > k1)
            {
                Console.WriteLine(k);
                Console.Write("The largest common end is at the left: ");
                for (int i = 0; i < k; i++)
                {
                    Console.Write(words2[i] + " ");
                }
            }
            else if (k1 > k)
            {
                Console.WriteLine(k1);
                Console.Write("The largest common end is at the right: ");
                if (words2.Length<words1.Length)
                {
                    for (int i = n - k1; i < n; i++)
                    {
                        Console.Write(words2[i] + " ");
                    }
                }
                else
                {
                    for (int i = n - k1; i < n; i++)
                    {
                        Console.Write(words1[i] + " ");
                    }
                }
            }
            else if (k == 0 && k1 == 0)
            {
                Console.Write("No common words at the left and right");
            }
            else if (k == k1)
            {
                Console.Write("Bye");
            }




        }
    }
}
