using System;

namespace _6
{
    class Employee
    {
        string name, position, department,email;
        double salary;
        int age;

        public string Name { set; get; }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public string Position
        {
            set { position = value; }
            get { return position; }
        }

        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public Employee(string n,string p ,string d,string e,double s,int a)
        {
            name = n;
            position = p;
            department = d;
            email = e;
            salary = s;
            age = a;
        }
        public Employee(string str1)
        {
            string[] str = str1.Split(" ");

            name = str[0];
            salary = Math.Round((Convert.ToDouble(str[1])), 2);
            position = str[2];
            department = str[3];
            if (str.Length == 6)
            {
                email = str[4];
                age = Convert.ToInt32(str[5]);
            }
            else if (str.Length == 5)
            {
                if (int.TryParse(str[4], out int age1))
                {
                    age = age1;
                    email = "n/a";
                }
                else
                {
                    email = str[4];
                    age = -1;
                }
            }
            else
            {
                age = -1;
                email = "n/a";
            }
        }

        public void Print()
        {
            Console.WriteLine($"{name} {salary} {email} {age}");
        }

    }




    class pr6
    {

        static string average(Employee[] e)
        {
            int k = 0;
            string p ,max_p = " ";
            double aver = 0,ave = 0;

            for(int i = 0; i < e.Length; i++)
            {
                p = e[i].Department;
                
                for (int j = 0; j < e.Length; j++)
                {
                    if (e[j].Department == p)
                    {
                        aver += e[j].Salary;
                        k++;
                    }
                }
                if ((aver / Convert.ToDouble(k)) > ave)
                {
                    ave = aver / Convert.ToDouble(k);
                    max_p = p;
                }
                    k = 0;
                    aver = 0;
            }
            return max_p;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str;
            Employee[] employees = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();

                employees[i] = new Employee(str);
            }

            string k = average(employees);
            int r = 0;
            Console.WriteLine("Highest Average Salary: " + k);
            foreach(var i in employees)
            {
                if(i.Department == k)
                {
                    r++;
                }
            }

            Employee[] e = new Employee[r];
            int j = 0;

            foreach(var i in employees)
            {
                if(i.Department == k)
                {
                    e[j] = i;
                    j++;
                }
            }

            for(int i = 0; i < e.Length; i++)
            {
                for(int ji = i + 1; ji < e.Length -1 ; ji++)
                {
                    if(e[i].Salary < e[j].Salary)
                    {
                        Employee p;
                        p = e[i];
                        e[i] = e[j];
                        e[j] = p;
                    }
                }
            }

            foreach(var i in e)
            {
                i.Print();
            }

        }
    }
}
