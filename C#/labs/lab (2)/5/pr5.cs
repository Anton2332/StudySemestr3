using System;
using System.Linq;

namespace _5
{
    class pr5
    {
        static void Main(string[] args)
        {
            Console.Write("arr1 = ");
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            Console.Write("arr2 = ");
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool arr = true;

            int n;

            if(arr1.Length < arr2.Length)
            {
                n = arr1.Length;
            }
            else
            {
                n = arr2.Length;
            }
            int q = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    arr = false;
                    break;
                }
                else if (arr1[i] == arr2[i])
                    q++;
            }

            if (arr && q == n)
                if(arr2.Length < arr1.Length)
                    arr = false;
            
            if (arr)
            {
                foreach(char k in arr1)
                {
                    Console.Write(k);
                }
                Console.WriteLine(" ");
                foreach (char k in arr2)
                {
                    Console.Write(k);
                }
            }
            else
            {
                foreach (char k in arr2)
                {
                    Console.Write(k);
                }
                Console.WriteLine(" ");
                foreach (char k in arr1)
                {
                    Console.Write(k);
                }
            }

        }
    }
}
