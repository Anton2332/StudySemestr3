using System;

namespace _4
{
    class pr4
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for(int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;

            for(int i = 2; i <= n; i++)
                if (primes[i] == true)
                    for (int j = 2; i * j <= n; j++)
                        if (primes[i * j] == true)
                            primes[i * j] = false;
            
            for(int i = 0;i<= n; i++)
            {
                if(primes[i] == true)
                {
                    Console.Write(i + "  ");
                }
            }

        }
    }
}
