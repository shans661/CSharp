using Interpreter.AbstractClas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Features.Expressions
{
    /// <summary>
    /// Concrete expression
    /// </summary>
    class HundredExpression : Expression
    {
        public override string Five()
        {
            return "D";
        }

        public override string Four()
        {
            return "CD";
        }

        public override int Multiplier()
        {
            return 100;
        }

        public override string Nine()
        {
            return "CM";
        }

        public override string One()
        {
            return "C";
        }
    }
}
