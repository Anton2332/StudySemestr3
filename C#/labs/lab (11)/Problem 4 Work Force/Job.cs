using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Work_Force
{
    internal class Job
    {
        string _name;
        int _hoursRequired;
        IEmployee _employee;
        public Job(IEmployee employee,string name,int hoursRequired)
        {
            _name = name;
            _hoursRequired = hoursRequired;
            _employee = employee;
        }

        public void Update()
        {
            _hoursRequired -= _employee.HoursPerWeek;
            if (_hoursRequired <= 0)
                OnJobFinished(); 
        }

        public event EventHandler<JobEventArgs> JobFinished;

        void OnJobFinished()
        {
            Console.WriteLine($"Job {_name} done!");
            JobFinished?.Invoke(this, new JobEventArgs(this));
        }

        public override string ToString()
        {
            return $"Job: {_name} Hours Remaining: {_hoursRequired}";
        }
    }
}
