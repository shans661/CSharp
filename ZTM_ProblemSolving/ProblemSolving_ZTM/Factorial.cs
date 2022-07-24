using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    public class Factorial
    {
        int resursiveResult = 1;
        public int FindFactorialIterative(int number)
        {
            int result = 1;
            for(int index = 1; index <= number; index++)
            {
                result *= index;
            }

            return result;
        }

        public int FindFactorialRecursive(int number)
        {
            if(number <= 1)
            {
                return number;
            }
            return number * FindFactorialRecursive(--number);
        }
    }
}
