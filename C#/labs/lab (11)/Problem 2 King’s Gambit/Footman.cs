using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_King_s_Gambit
{
    internal class Footman :  IComparer<IUnits>, IUnits
    {
        string _name;

        public Footman(string name)
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
