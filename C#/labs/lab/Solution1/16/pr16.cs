using System;

namespace _16
{
    class pr16
    {
        static void Main(string[] args)
        {

            int n;

            //if (n == "1" || n == "2" || n == "3" || n == "4" || n == "5" || n == "6" || n == "7")
            //{
            //    k = int.Parse(n);
            //}
            //else
            //{
            //    k = 0;
            //}
            try
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                n = 0;
            }



            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("not valid");
                    break;
            }


        }
    }
}
