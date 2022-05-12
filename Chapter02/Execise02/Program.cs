using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise02 {
    class Program {
        static void Main(string[] args)  {
            PrintInchToMeter(1, 10);
        }
        private static void PrintInchToMeter(int start, int stop)
        {
            for (int inch = start; inch <= stop; inch++)
            {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0}in = {1:0.0000}m", inch, meter);
            }
        }
    }
}
