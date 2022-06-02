using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_King_s_Gambit_Extended
{
    internal class HitsEventArgs : EventArgs
    {
            int _hits;

            public HitsEventArgs(int hits)
            {
                _hits = hits;
            }

            public int Hits { get => _hits; private set => _hits = value; }

        
    }
}
