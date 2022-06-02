using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Dependency_Inversion
{
    internal static class Handler
    {
        public static void Add(int first,int second)
        {
            Console.WriteLine(first + second);
        } 

        public static void Subtract(int first,int second)
        {
            Console.WriteLine(first - second);
        }

        public static void Divide(int first,int second)
        {
            Console.WriteLine(first / second);
        }

        public static void Multiply(int first,int second)
        {
            Console.WriteLine(first * second);
        }
    }
}
