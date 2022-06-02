using System;

namespace _13
{
    class pr13
    {
        static void Main(string[] args)
        {
            int n;
            bool result;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            if(n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Console.WriteLine(result);
        }
    }
}
