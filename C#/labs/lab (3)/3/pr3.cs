using System;

namespace _3
{

    class Person
    {
        string name;
        private int age;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public void Print()
        {
            Console.WriteLine(name + "       " + age);
        }
    }

    class Family {
        Person[] myFamily;
        int n;
        public Family(int i)
        {
            myFamily = new Person[i];
            n = i;
            for (int j = 0; j < n; j++)
            {
                myFamily[j] = new Person();
            }
        }

        public void AddMember(Person member,int i)
        {
           myFamily[i]  = member;
        }

        public Person GetOldestMember()
        {
            Person max = new Person();
            max = myFamily[0];
            for(int i = 0; i < n; i++)
            {
                if(max.Age < myFamily[i].Age)
                {
                    max = myFamily[i];
                }
            }

            return max;
        }

        public void Print()
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{myFamily[i].Name}  {myFamily[i].Age}");
            }
        }
    }



    class pr3
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt16(Console.ReadLine());

            Family family = new Family(n);

            for(int i = 0; i < n; i++)
            {
                Person a = new Person();

                Console.Write("Введіть імя : ");
                a.Name = Console.ReadLine();
                Console.Write("Введіть вік : ");
                a.Age = Convert.ToInt32(Console.ReadLine());

                family.AddMember(a, i);
            }


            family.Print();

            Person k = new Person();


            Console.WriteLine("Older : ");
            k = family.GetOldestMember();

            Console.WriteLine($"{k.Name}  {k.Age}");


        }
    }
}
