using System;

namespace _15
{
    class pr15
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string product;

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            int k = 0;

            if (a < 0)
            {
                k++;
            }

            if(b<0)
            {
                k++;
            }

            if (c < 0)
            {
                k++;
            }

            if (k == 1 || k == 3)
            {
                product = "Negative";
            }
            else if (k == 0 || k == 2)
            {
                product = "Positive";
            }
            else
                product = " - ";

            Console.WriteLine(product);

        }
    }
}
