using System;

namespace _8
{
    class Engine
    {
        int EngineSpeed, EnginePower;

        public Engine(string a,string b)
        {
            EngineSpeed = Convert.ToInt32(a);
            EnginePower = Convert.ToInt32(b);
        }
        public int enginePower {
            set { EnginePower = value; }
            get
            {
                return EnginePower;
            }
        }

    }

    class Cargo
    {
        int CargoWeight;
        string CargoType;

        public Cargo(string a,string b)
        {
            CargoWeight = Convert.ToInt32(a);
            CargoType = b;
        }

        public string cargoType
        {
            set { CargoType = value; }
            get { return CargoType; }
        }

    }

    class Tire
    {
        double[] TirePressure = new double[4];
        int[] TireAge = new int[4];
        double Pressure;
        public double pressure
        {
            set { Pressure = value; }
            get { return Pressure; }
        }
        public Tire(double a1, int b1, double a2, int b2, double a3, int b3, double a4,int b4)
        {
            TirePressure[0] = a1;
            TirePressure[1] = a2;
            TirePressure[2] = a3;
            TirePressure[3] = a4;
            Pressure = (a1 + a2 + a3 + a4) / 4.0;

            TireAge[0] = b1;
            TireAge[1] = b2;
            TireAge[2] = b3;
            TireAge[3] = b4;

        }

    }

    class Car
    {
        string model;
        Engine eng;
        Cargo carg;
        Tire tires;


        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public Engine Eng
        {
            set { eng = value; }
            get { return eng; }
        }

        public Cargo Carg
        {
            set { carg = value; }
            get { return carg; }
        }

        public Tire Tires
        {
            set { tires = value; }
            get { return tires; }
        }

        public Car(string str)
        {
            string[] car_str = str.Split(" ");
            model = car_str[0];
            eng = new Engine(car_str[1], car_str[2]);
            carg = new Cargo(car_str[3], car_str[4]);
            tires = new Tire(Convert.ToDouble(car_str[5]), Convert.ToInt32(car_str[6]), Convert.ToDouble(car_str[7]), Convert.ToInt32(car_str[8]), Convert.ToDouble(car_str[9]), Convert.ToInt32(car_str[10]), Convert.ToDouble(car_str[11]), Convert.ToInt32(car_str[12]));
        }

    }


    class pr8
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Car[] arr = new Car[n];
            string str;
            for(int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                arr[i] = new Car(str);
            }

            string str_type;
            str_type = Console.ReadLine();
            if(str_type == "fragile")
            {
                foreach(var i in arr)
                {
                    if (i.Carg.cargoType == str_type && i.Tires.pressure < 1)
                        Console.WriteLine(i.Model);
                }
            }else if (str_type == "flamable")
            {
                foreach (var i in arr)
                {
                    if (i.Carg.cargoType == str_type && i.Eng.enginePower > 250)
                        Console.WriteLine(i.Model);
                }
            }



        }
    }
}
