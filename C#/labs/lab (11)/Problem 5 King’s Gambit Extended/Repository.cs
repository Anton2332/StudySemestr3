using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_King_s_Gambit
{
    delegate void EventHandler(object sender, NameEventArgs e);
    internal class Repository
    {
        

        King _king;
        SortedSet<IUnits> _units = new SortedSet<IUnits>();
        public void addKing(string name) 
        {
            _king = new King(name);
        }

        

        public void addRoyalGuard(string name, EventHandler i, EventKill j)
        {
            IUnits u = new RoyalGuard(name);
            u.EventUnit += i;
            u.EKill += j;
            _units.Add(u);
        }

        public void addFootmen(string name, EventHandler i, EventKill j)
        {
            IUnits u = new Footman(name);
            u.EventUnit += i;
            u.EKill += j;
            _units.Add(u);
        }

        public void kill(string name)
        {
            foreach(var i in _units)
            {
                if (i.Name == name)
                {
                    if(i.Kill())
                    _units.Remove(i);
                    break;
                }
            }
        }

        public King King => _king;


        public void attack()
        {
            King.Attack();   
            foreach(var i in _units)
            {
                i.Attack();
            }
        }
        

    }
}
