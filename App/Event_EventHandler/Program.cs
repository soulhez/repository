using System;

namespace com.soulhez
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Counter();
            c.ThresholdReached += ThresholdReached;
        }

        private static void ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }
    }
}
