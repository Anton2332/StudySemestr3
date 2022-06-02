using System;

namespace _1
{

    class Person {
        string name;
        private int age;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age 
        {
            set{ age = value; } 
            get{ return age; }
        }

        public Person(string n,int a)
        {
            name = n;
            age = a;
        }

        public Person()
        {
            name = "No name";
            age = 0;
        }

        public void Print()
        {
            Console.WriteLine(name + "       " + age);
        }
    }

    class pr1
    {
        static void Main(string[] args)
        {
            Person A = new Person("Pecho" ,20);
            Person A1 = new Person();
            A1.Age = 18;
            A1.Name = "Gosho";
            Person A2 = new Person("Stamat", 43);

            Console.WriteLine("Name   Age");
            A.Print();
            A1.Print();
            A2.Print();





            
        }
    }
}
