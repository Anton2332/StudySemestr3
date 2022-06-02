using System;
using System.Linq;

namespace _10
{
    class pr10
    {
        static void Main(string[] args)
        {
            Console.Write("Array = ");
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            int q = 0;
            for(int i = 0; i < number.Length; i++)
            {
                for(int j = i; j < number.Length; j++)
                {
                    if(number[i] + k == number[j] || number[i] - k == number[j])
                    {
                        q++;
                    }
                }
            }
            Console.WriteLine(q);

        }
    }
}
