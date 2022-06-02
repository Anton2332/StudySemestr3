using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_King_s_Gambit
{
    internal class Engine
    {
        Repository _repository;
        public Engine(Repository repository)
        {
            _repository = repository;
        }

        public void Run()
        {
            string str = Console.ReadLine();
            _repository.addKing(str);
            _repository.King.EventKing += Handler.KingEvent;

            str = Console.ReadLine();
            string[] arrStr = str.Split(" ");
            foreach (var i in arrStr)
            {
                _repository.addRoyalGuard(i, Handler.RoyalGuardEvent);
            }

            str = Console.ReadLine();
            arrStr = str.Split(" ");
            foreach (var i in arrStr)
            {
                _repository.addFootmen(i, Handler.FootmanEvent);
            }
            while (true)
            {
                str = Console.ReadLine();
                arrStr = str.Split(" ");

                switch (arrStr[0].ToLower())
                {
                    case "kill":
                        _repository.kill(arrStr[1]);
                        break;
                    case "attack":
                        _repository.attack();
                        break;
                    case "end":
                        Environment.Exit(0);
                        break;
                }
            }


        }

    }
}
