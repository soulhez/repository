using System;
using System.Collections.Generic;
using System.Text;

namespace com.soulhez
{
    class Counter
    {
        public event EventHandler ThresholdReached;
        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            handler?.Invoke(this, e);
        }
    }
}
