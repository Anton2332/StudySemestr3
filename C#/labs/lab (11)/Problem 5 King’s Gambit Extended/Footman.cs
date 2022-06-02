using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_5_King_s_Gambit_Extended;

namespace Problem_2_King_s_Gambit
{
    internal class Footman :  IComparer<IUnits>, IUnits
    {
        string _name;
        int _hits = 2;

        public Footman(string name)
        {
            _name = name;
        }

        public event EventKill EKill;
        public bool Kill()
        {
            Hits--;
            return (bool)EKill?.Invoke(this, new HitsEventArgs(Hits));
        }

        public int Hits { get => _hits;set=> _hits = value; }

        public string Name
        {
            get => _name; set => _name = value;
        }

        public event EventHandler EventUnit;


        public void Attack()
        {
            OnFootman(new NameEventArgs(Name));
        }
        public void OnFootman(NameEventArgs args)
        {
            EventUnit?.Invoke(this, args);
        }

        public int Compare(IUnits? x, IUnits? y)
        {
            Footman guard1 = x as Footman;
            Footman guard2 = y as Footman;
            return guard2.Name.CompareTo(guard1.Name);
        }

        public int CompareTo(IUnits other)
        {
            Footman guard = other as Footman;
            return this.Name.CompareTo(guard?.Name);
        }

    }
}
