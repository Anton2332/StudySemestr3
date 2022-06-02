using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Event_Implementation
{
    delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);
    class Dispatcher
    {
        public event NameChangeEventHandler NameChange;
        string _name;

        public string Name 
        { 
            get => _name; 
            set
            {
                _name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }

    }
}
