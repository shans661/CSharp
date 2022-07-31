using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    internal class FibonacciSeries
    {
        public int FibSeries(int n, string from)
        {
            Console.WriteLine($"Value: {n} from : {from}");
            if (n <= 1)
                return n; 

            return FibSeries(n - 1, "first") + FibSeries(n-2, "second");
        }

    }
}
