using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime startTime;
        public void Start()
        {
            startTime = DateTime.Now; 
        }
        public void Stop()
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            Console.WriteLine("The elapsed time is: {0}s {1}ms.", elapsed.Seconds, elapsed.Milliseconds);
        }
    }
}
