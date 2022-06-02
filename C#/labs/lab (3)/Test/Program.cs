using System;

namespace Test
{
    class test 
    {

        public string Name { get; set; }
        public void print()
        {
            Console.WriteLine(Name);
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            test a = new test();
            a.Name = "asdf";
            Console.WriteLine(a.Name);
            a.print();

        }
    }
}
