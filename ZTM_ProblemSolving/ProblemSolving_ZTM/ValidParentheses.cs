//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
 

//Example 1:

//Input: s = "()"
//Output: true
//Example 2:

//Input: s = "()[]{}"
//Output: true
//Example 3:

//Input: s = "(]"
//Output: false

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            // {[()]}
            char[] inputArray = s.ToArray();

            if(inputArray.Length <= 1)
                return false;
            Stack<char> comparisionStack = new Stack<char>();

            foreach(char input in inputArray)
            {
                if(input == '{' || input == '[' || input == '(')
                {
                    comparisionStack.Push(input);
                }
                else
                {
                    switch(input)
                    {
                        case '}':
                            if(comparisionStack.Count > 0 && comparisionStack.Pop() == '{')
                            {
                                continue;
                            }

                            return false;
                        case ']':
                            if (comparisionStack.Count > 0 && comparisionStack.Pop() == '[')
                            {
                                continue;
                            }

                            return false;
                        case ')':
                            if (comparisionStack.Count > 0 && comparisionStack.Pop() == '(')
                            {
                                continue;
                            }

                            return false;
                            default:
                            return false;
                    }
                }
            }

            if (comparisionStack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
