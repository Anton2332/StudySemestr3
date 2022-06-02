using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_King_s_Gambit
{
    internal class RoyalGuard : IComparer<IUnits>, IUnits
    {
        string _name;

        public RoyalGuard(string name)
        {
            _name = name;
        }

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
