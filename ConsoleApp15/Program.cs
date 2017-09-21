using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                // CPU is maxed out during this call.
                // ... (Try making it much larger to test.)
                Thread.SpinWait(100000000);
                Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
            }
        }
    }
}
