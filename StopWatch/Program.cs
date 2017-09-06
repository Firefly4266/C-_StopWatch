using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start timer.");
            Console.ReadLine();

            StopWatch watch = new StopWatch();
            watch.Start();

            Console.WriteLine("Press enter to stop the timer.");
            Console.ReadLine();
            watch.Stop();
        }
    }
}
