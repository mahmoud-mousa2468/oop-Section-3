using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex02
{
    internal class SeriesTwo : ISeries
    {
        public int Current { set; get; }

        public void Next()
        {
            for (int i = 0; i < 10; i++)
            {
                Current += 2;
                Console.Write($"{Current} ");
            }
            Reset();
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
