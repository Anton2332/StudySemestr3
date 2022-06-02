using System;

namespace Problem_1_Event_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var disp = new Dispatcher();
            var handler = new Handler();

            disp.NameChange += handler.OnDispatcherNameChange;

            while (true)
            {
                string str = Console.ReadLine();

                if (str.ToLower() == "end")
                    break;

                disp.Name = str;
            }
        }
    }
}
