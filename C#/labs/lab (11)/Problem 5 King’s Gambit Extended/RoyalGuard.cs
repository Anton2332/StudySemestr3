using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_5_King_s_Gambit_Extended;

namespace Problem_2_King_s_Gambit
{
    delegate bool EventKill(object sender, HitsEventArgs e);
    internal class RoyalGuard : IComparer<IUnits>, IUnits
    {
        string _name;
        int _hits = 3;

        public RoyalGuard(string name)
        {
            _name = name;
        }

        public event EventKill EKill;
        public bool Kill()
        {
            Hits--;
            return (bool)EKill?.Invoke(this,new HitsEventArgs(Hits));
        }

        public int Hits { get => _hits;set => _hits = value; }

        public string Name
        {
            get => _name; set => _name = value;
        }

        public event EventHandler EventUnit;

        public void Attack()
        {
            OnRoyalGuard(new NameEventArgs(Name));
        }
        public void OnRoyalGuard(NameEventArgs args)
        {
            EventUnit?.Invoke(this, args);
        }

        public int Compare(IUnits? x, IUnits? y)
        {
            RoyalGuard guard1 = x as RoyalGuard;
            RoyalGuard guard2 = y as RoyalGuard;
            return guard2.Name.CompareTo(guard1.Name);
        }

        public int CompareTo(IUnits other)
        {
            RoyalGuard guard = other as RoyalGuard;
            return this.Name.CompareTo(guard.Name); 
        }
    }
}
