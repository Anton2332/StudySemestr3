using System;

namespace _11
{
    class pr11
    {
        static void Main(string[] args)
        {
            int n, number;
            double nDigit;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("number = ");
            number = int.Parse(Console.ReadLine());

            nDigit =Math.Floor((number / Math.Pow(10, n - 1))%10);

            if(nDigit == 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine(nDigit);

        }
    }
}
