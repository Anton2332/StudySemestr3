using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Work_Force
{
    internal class StandardEmployee : IEmployee
    {
        string _name;
        const int _hoursPerWeek = 40;
        
        public StandardEmployee(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public int HoursPerWeek => _hoursPerWeek;

    }
}
