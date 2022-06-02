using System;

namespace _9
{
    class pr9
    {
        static void Main(string[] args)
        {
            double a, b, h;
            double area;

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("h = ");
            h = Convert.ToDouble(Console.ReadLine());

            area = (a + b) / 2 * h;

            Console.WriteLine(area);
        }
    }
}
