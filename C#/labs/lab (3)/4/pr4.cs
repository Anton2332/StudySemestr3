using System;

namespace Pr4
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

    class pr4
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Person[] person = new Person[n];

            for (int i = 0; i < n; i++)
            {
                person[i] = new Person();

                string[] arr = Console.ReadLine().Split(" ");

                person[i].Age = Convert.ToInt32(arr[1]);
                person[i].Name = arr[0];
            }

            int q = 0;

            for (int i = 0; i < n; i++)
            {
                if (person[i].Age > 30)
                {
                    q++;
                }
            }

            Person[] sr = new Person[q];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (person[i].Age > 30)
                {
                    sr[k] = person[i];
                    k++;
                }
            }


            string s;
            int a;
            {
                //for (int i = 0; i < q - 1; i++)
                //    for (int j = i; j >= 0; j--)
                //    {
                //        if (String.Compare(sr[j].Name, sr[j + 1].Name) > 0)
                //        {
                //            s = sr[j].Name;
                //            sr[j].Name = sr[j + 1].Name;
                //            sr[j + 1].Name = s;
                //            a = sr[j].Age;
                //            sr[j].Age = sr[j + 1].Age;
                //            sr[j + 1].Age = a;
                //        }
                //    }
            }


            for(var i = 0; i < q;)
            {
                if (i == 0 || String.Compare(sr[i].Name, sr[i - 1].Name) > 0)
                    i++;
                else
                {
                    s = sr[i].Name;
                    sr[i].Name = sr[i - 1].Name;
                    sr[i - 1].Name = s;
                    a = sr[i].Age;
                    sr[i].Age = sr[i - 1].Age;
                    sr[i - 1].Age = a;
                }
            }

            

            for (int i = 0; i < q; i++)
            {
                sr[i].Print();
            }
        }
    }
}
