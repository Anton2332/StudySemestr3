using System;

namespace _8
{
    class pr8
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double average;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            

            average = ((Convert.ToDouble(a) + b + c) / 3);

            Console.WriteLine(Math.Round(average,5));

        }
    }
}
