using System;

namespace _12
{
    class pr12
    {
        static void Main(string[] args)
        {
            int n;
            bool result;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            if (n > 20 && (n % 2) == 1)
            {
                result = true;
            }
            else
                result = false;

            Console.WriteLine(result);
        }
    }
}
