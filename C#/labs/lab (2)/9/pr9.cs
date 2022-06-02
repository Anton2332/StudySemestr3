using System;
using System.Linq;

namespace _9
{
    class pr9
    {
        static void Main(string[] args)
        {
            
            //char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr = new char[26];
            int j = 0;
            for(int i = 97; i < 123; i++)
            {
                arr[j] = Convert.ToChar(i);
                j++;
            }

            Console.Write("str1 = ");
            string str1 = Console.ReadLine();

            for(int i = 0; i < str1.Length; i++)
            {
                for(int k = 0; k < arr.Length; k++)
                {
                    if(str1[i] == arr[k])
                    {
                        Console.WriteLine(str1[i] + " -> " + k);
                    }
                }
            }
        }
    }
}
