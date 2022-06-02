using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_King_s_Gambit
{
    internal interface IUnits : IComparable<IUnits>
    {
        public string Name { get; set; }
        public int CompareTo(IUnits other);
        public event EventHandler EventUnit;
        public void Attack();
    }
}
