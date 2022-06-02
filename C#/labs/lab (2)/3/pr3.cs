using System;
using System.Linq;

namespace _3
{
    class pr3
    {


        static void Main(string[] args)
        {
            
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n % 4 != 0){
                Console.WriteLine("Enter n % 4 = 0");
                Console.Write("N = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] array1 = new int[n];
            for(int i = 0;i<n;i++) {
                Console.Write("arrayq[" + i + "] = ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int j = 0;
            int[] Array1 = new int[n / 2];
            int[] Array2 = new int[n / 2];
            for(int i = (n / 4) -1; i >= 0; i--)
            {
                Array1[j] = array1[i];
                j++;
            }
            for (int i = n-1; i >= n- (n/4); i--)
            {
                Array1[j] = array1[i];
                j++;
            }
            int ki = 0;
            for (int i = n / 4; i < n - (n/4); i++)
            {
                Array2[ki] = array1[i];
                ki++;
            }
            int[] sum = new int[n/2];
            for(int i = 0; i < n / 2; i++)
            {
                sum[i] = Array1[i] + Array2[i];
                Console.Write(sum[i] + "  ");
            }
        }
    }
}
