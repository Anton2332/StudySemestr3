using System;

namespace Lab_10
{
    class Engine 
    {
        string engineModel;
        double enginePower, engineDisplacement;
        string engineEfficiency;

        public string EngineModel
        {
            set { engineModel = value; }
            get { return engineModel; }
        }

        public Engine()
        {

        }

        public Engine(string str)
        {
            var str1 = str.Split(" ");
            engineModel = str1[0];
            enginePower = Convert.ToDouble(str1[1]);
            if (str1.Length == 4)
            {
                engineDisplacement = Convert.ToDouble(str1[2]);
                engineEfficiency = str1[3];
            }else if(str1.Length == 3)
            {
                if(double.TryParse(str1[2],out var q))
                {
                    engineDisplacement = q;
                    engineEfficiency = "n/a";
                }
                else
                {
                    engineEfficiency = str1[2];
                    engineDisplacement = -1;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("  " + engineModel + ":");
            Console.WriteLine("    Power: " + enginePower);
            if(engineDisplacement == -1)
            {
                Console.WriteLine("    Displacement: n/a ");
            }
            else
            {
                Console.WriteLine("    Displacement: " + engineDisplacement);
            }
            Console.WriteLine("    Efficiency: " + engineEfficiency);
        }

    }

    class Car
    {
        string carModel,color;
        Engine e;
        double carWeight;

        public Car(string s,Engine a,double b,string c)
        {
            carModel = s;
            e = a;
            carWeight = b;
            color = c;

        }

        public void Print()
        {
            Console.WriteLine(carModel + ":");
            e.Print();
            if (carWeight == -1)
                Console.WriteLine("  Weight: n/a");
            else
                Console.WriteLine("  Weight: " + carWeight);
            Console.WriteLine("  Color: " + color);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            int n,m;
            n = Convert.ToInt32(Console.ReadLine());
            Engine[] engines = new Engine[n];
            string str;
            for(int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                engines[i] = new Engine(str);
            }
            string a;
            Engine b = new Engine();
            double c;
            string d;
            m = Convert.ToInt32(Console.ReadLine());
            Car[] car = new Car[m];
            string[] str1;
            for (int i = 0; i < m; i++)
            {
                str = Console.ReadLine();
                str1 = str.Split(" ");
                a = str1[0];
                for(int j = 0; j < n; j++)
                {
                    if(engines[j].EngineModel == str1[1])
                    {
                        b = engines[j];
                        break;
                    }
                }
                if (str1.Length == 4)
                {
                    c = Convert.ToDouble(str1[2]);
                    d = str1[3];
                }
                else if(str1.Length == 3)
                {
                    if (double.TryParse(str1[2], out var r))
                    {
                        c = r;
                        d = "n/a";
                    }
                    else
                    {
                        c = -1;
                        d = str1[2];
                    }
                }else
                {
                    c = -1;
                    d = "n/a";
                }

                car[i] = new Car(a, b, c, d);

            }
            for (int i = 0; i < m; i++)
                car[i].Print();


        }
    }
}
