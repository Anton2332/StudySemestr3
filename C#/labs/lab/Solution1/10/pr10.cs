using System;

namespace _10
{
    class pr10
    {
        static void Main(string[] args)
        {
            int n, lastDigit;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            lastDigit = n % 10;

            Console.WriteLine("lastDigit = " + lastDigit);
        }
    }
}
