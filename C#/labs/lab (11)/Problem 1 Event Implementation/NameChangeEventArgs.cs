using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Event_Implementation
{
    class NameChangeEventArgs : EventArgs
    {
        string _name;

        public NameChangeEventArgs(string name)
        {
            Name = name;
        }

        public string Name { get => _name; private set => _name = value; }

    }
}
