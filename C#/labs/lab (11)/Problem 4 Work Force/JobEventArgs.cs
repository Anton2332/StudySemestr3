using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Work_Force
{
    internal class JobEventArgs : EventArgs
    {
        public JobEventArgs(Job job)
        {
            Job = job;
        }

        public Job Job { get; private set; }
    }
}
