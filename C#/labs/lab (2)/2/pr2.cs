using System;
using System.Linq;

namespace _2
{
    class pr2
    {
        static void Main(string[] args)
        {
            Console.Write("Array = ");
            int [] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int n = number.Length;
            int[] sum = new int[n];
            for(int i = 0;i<n;i++)
            {
                sum[i] = 0;
            }
            int q;
            for(int i = 0;i<k;i++)
            {
                q = number[n - 1];
                for (int j = n-2;j>=0;j--)
                {                                    
                    number[j+1] = number[j];
                    if (j == 0)
                    {
                        number[j] = q;
                    }
                }
                foreach(int qi in number)
                {
                    Console.Write(qi + "\t");
                }
                Console.WriteLine(" ");
                int ki = 0;
                foreach(int qi in number)
                {
                    sum[ki] = sum[ki] + qi;
                    ki++;
                }
            }
            foreach(int qi in sum) { 
                Console.Write(qi + "\t");
            }
            Console.WriteLine(" ");
        }
    }
    }


