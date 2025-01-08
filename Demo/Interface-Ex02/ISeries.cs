using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex02
{
    internal interface ISeries
    {
        // 0 2 4 6 8 10 12 14
        // 0 3 6 9 12 15
        // 0 4 8 12 16 20
        int Current { set; get; } //Signature Of Property
        void Next();
        void Reset();

    }
}
