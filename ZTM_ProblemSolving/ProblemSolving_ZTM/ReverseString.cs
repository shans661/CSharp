using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    internal class ReverseString
    {
        public static string Reverse(string input)
        {

            return string.Join("", input.ToArray().Reverse<char>());
        }
    }
}
