using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Features
{
    class Context
    {
        /// <summary>
        /// Stores input and output
        /// </summary>
        public string Input { get; set; }
        public int OutPut { get; set; }

        public Context(string input)
        {
            Input = input;
        }
    }
}
