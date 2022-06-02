using System;

namespace _17
{
    class pr17
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int factorial = 1;

            for(int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);

        }
    }
}
