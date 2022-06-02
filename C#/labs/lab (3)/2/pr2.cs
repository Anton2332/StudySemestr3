using System;

namespace _2
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
        
        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int a)
        {
            name = "No name";
            age = a;
        }

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        

        public void Print()
        {
            Console.WriteLine(name + "       " + age);
        }
    }

    class pr2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name      Age");
            Person A1 = new Person();
            A1.Print();
            Person A2 = new Person(30);
            A2.Print();
            Person A3 = new Person("Pasha", 18);
            A3.Print();

        }
    }
}
