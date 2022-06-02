using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_King_s_Gambit
{
    internal class King
    {
        public event EventHandler EventKing;
        string _name;

        public King(string name)
        {
            _name = name;
        }

        public string Name
        {
            get => _name; set => _name = value; 
        }
        public void Attack()
        {
            OnKing(new NameEventArgs(Name));
        }
        public void OnKing(NameEventArgs args)
        {
            EventKing?.Invoke(this, args);
        }
    }
}
