using System;

namespace _7
{
    class Car
    {
        string model;
        double fuel_amount, fuel_consumption, distance_traveled = 0;
        static int k = 0;

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public double Fuel_amount
        {
            set { fuel_amount = value; }
            get { return fuel_amount; }
        }

        public double Fuel_consumption
        {
            set { fuel_consumption = value; }
            get { return fuel_consumption; }
        }

        public double Distance_traveled
        {
            set { distance_traveled = value; }
            get { return distance_traveled; }
        }

        public int K
        {
            set { k = value; }
            get { return k; }
        }

        public void method(double q)
        {
            if(fuel_consumption * q > fuel_amount)
            {
                k++;
            }
            else
            {
                fuel_amount = fuel_amount - fuel_consumption * q;
                distance_traveled = distance_traveled + q;
            }

        }

    }





    class pr7
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Car[] arr = new Car[n];

            for(int i = 0; i < n; i++)
                arr[i] = new Car();
            string[] str;
            int k = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter car : ");
                str = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++)
                {
                    if(str[0] == arr[j].Model)
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    arr[i].Model = str[0];
                    arr[i].Fuel_amount = Convert.ToDouble(str[1]);
                    arr[i].Fuel_consumption = Convert.ToDouble(str[2]);
                }
                else
                {
                    k = 0;
                    i--;
                }
            }

            string end = "";
            end = Console.ReadLine();
            while (end != "End")
            {
                string[] arr2 = end.Split(" ");
                for(int i = 0; i < n; i++)
                {
                    if(arr[i].Model == arr2[1])
                    {
                        arr[i].method(Convert.ToDouble(arr2[2]));
                    }
                }
                end = Console.ReadLine();
            }

            for(int i = 0; i < arr[0].K; i++)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Model + " " + Math.Round((arr[i].Fuel_amount), 2) + " " + arr[i].Distance_traveled);
            }

            
            
        }
    }
}
