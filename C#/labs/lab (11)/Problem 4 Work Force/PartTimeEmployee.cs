using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Work_Force
{
    internal class PartTimeEmployee : IEmployee
    {
        string _name;
        const int _hoursPerWeek = 20;

        public PartTimeEmployee(string name)
        {
            _name = name;   
        }
        public string Name => _name;

        public int HoursPerWeek => _hoursPerWeek;


    }
}
