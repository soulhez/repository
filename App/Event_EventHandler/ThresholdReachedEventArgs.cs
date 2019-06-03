using System;
using System.Collections.Generic;
using System.Text;

namespace com.soulhez
{
    class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
