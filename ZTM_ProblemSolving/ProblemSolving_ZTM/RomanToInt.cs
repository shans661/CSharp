using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    internal class RomanToIntConversion
    {
        public int RomanToInt(string s)
        {
            char[] inputArray = s.ToArray();

            char previousChar = ' ';
            int result = 0;
            foreach (char item in inputArray)
            {
                switch (item)
                {
                    case 'I':
                        result += 1;
                        previousChar = 'I';
                        break;
                    case 'V':
                        if (previousChar == 'I')
                        {
                            result += 3;
                        }
                        else
                        {
                            result += 5;
                        }
                        previousChar = 'V';
                        break;
                    case 'X':
                        if (previousChar == 'I')
                        {
                            result += 8;
                        }
                        else
                        {
                            result += 10;
                        }
                        previousChar = 'X';
                        break;
                    case 'L':
                        if (previousChar == 'X')
                        {
                            result += 30;
                        }
                        else
                        {
                            result += 50;
                        }
                        previousChar = 'L';
                        break;
                    case 'C':
                        if (previousChar == 'X')
                        {
                            result += 80;
                        }
                        else
                        {
                            result += 100;
                        }
                        previousChar = 'C';
                        break;
                    case 'D':
                        if (previousChar == 'C')
                        {
                            result += 300;
                        }
                        else
                        {
                            result += 500;
                        }
                        previousChar = 'D';
                        break;
                    case 'M':
                        if (previousChar == 'C')
                        {
                            result += 800;
                        }
                        else
                        {
                            result += 1000;
                        }
                        previousChar = 'M';
                        break;
                }
            }

            return result;
        }

        public int RomanToIntHashMap(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>()
            {
                { 'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
            };

            char[] inputArray = s.ToArray();
            int result = 0;
            char previousChar = ' ';
            foreach (char item in inputArray)
            {
                if(previousChar == ' ' || keyValuePairs[previousChar] >= keyValuePairs[item] )
                {
                    result += keyValuePairs[item];
                }
                else
                {
                    result += keyValuePairs[item] - (keyValuePairs[previousChar] * 2);
                }

                previousChar = item;
            }

            return result;
        }
    }
}
