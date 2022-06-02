using System;

namespace _5
{
    class DateModifier
    {
        TimeSpan DifferenceDay;



        //int DayInYear(int a)
        //{
        //    int k;
        //    if (a % 4 == 0)
        //        k = 365;
        //    else
        //        k = 364;
        //    return k; 
        //}
        //int DayInMonth(int a, int b)
        //{
        //    int k;
        //    if (a == 4 || a == 6 || a == 9 || a == 11)
        //        k = 30;
        //    else if (a == 2)
        //    {
        //        if (b % 4 == 0)
        //            k = 29;
        //        else
        //            k = 28;
        //    }
        //    else
        //        k = 31;
        //    return k;
        //}



        public void CalculatesDay(string date1,string date2)
        {
            string[] arr;
            int year1,year2,month1,month2,day1,day2;
            if ((String.Compare(date1, date2)) < 0)
            {
                arr = date1.Split(" ");
                year1 = Convert.ToInt32(arr[0]);
                month1 = Convert.ToInt32(arr[1]);
                day1 = Convert.ToInt32(arr[2]);

                arr = date2.Split(" ");
                year2 = Convert.ToInt32(arr[0]);
                month2 = Convert.ToInt32(arr[1]);
                day2 = Convert.ToInt32(arr[2]);
            }
            else
            {
                arr = date2.Split(" ");
                year1 = Convert.ToInt32(arr[0]);
                month1 = Convert.ToInt32(arr[1]);
                day1 = Convert.ToInt32(arr[2]);

                arr = date1.Split(" ");
                year2 = Convert.ToInt32(arr[0]);
                month2 = Convert.ToInt32(arr[1]);
                day2 = Convert.ToInt32(arr[2]);
            }

            { 
            //if(year1 != year2)
            //{
            //    for (int i = year1 + 1; i < year2; i++)
            //        DifferenceDay += DayInYear(i);

            //    //for (int i = month1 + 1; i < month2; i++)
            //    //    DifferenceDay += DayInMonth(i, year2);

            //    for (int i = 1; i < month2; i++)
            //        DifferenceDay += DayInMonth(i, year2);
            //    DifferenceDay += day2;

            //    for (int i = month1 + 1; i <= 12; i++)
            //        DifferenceDay += DayInMonth(i, year1);

            //    DifferenceDay += (DayInMonth(month1, year1) - day1);
            //}
            //else
            //{
            //    for (int i = month1 + 1; i < month2; i++)
            //        DifferenceDay += DayInMonth(i, year2);
            //    DifferenceDay += (DayInMonth(month1, year1) - day1);
                
            //}

            //Console.WriteLine("Day = " + DifferenceDay);
            }

            var d1 = new DateTime(year1, month1, day1);
            var d2 = new DateTime(year2, month2, day2);

            DifferenceDay = d2 - d1;
            Console.WriteLine(DifferenceDay.Days);

        }

        
    }


    class pr5
    {
        static void Main(string[] args)
        {
            string str2, str1;

            Console.WriteLine("Enter date 1 : ");
            str1 = Console.ReadLine();

            Console.WriteLine("Enter date 2 : ");
            str2 = Console.ReadLine();

            var a = new DateModifier();

            a.CalculatesDay(str1, str2);

        }
    }
}
