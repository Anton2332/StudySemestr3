using System;

namespace _14
{
    class pr14
    {
        static void Main(string[] args)
        {
            int a, b, c, result,result0;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                result0 = a;
            }
            else
            {
                result0 = b;
            }

            if(result0 > c)
            {
                result = result0;
            }
            else
            {
                result = c;
            }

            Console.WriteLine("Result = " + result);
        }
    }
}
