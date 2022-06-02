using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_King_s_Gambit
{
    class NameEventArgs : EventArgs
    {
        string _name;

        public NameEventArgs(string name)
        {
            Name = name;
        }

        public string Name { get => _name; private set => _name = value; }

    }
}
