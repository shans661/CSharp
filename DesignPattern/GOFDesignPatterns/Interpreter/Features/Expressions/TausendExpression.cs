using Interpreter.AbstractClas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Features.Expressions
{
    /// <summary>
    /// Concrete terminal expression
    /// </summary>
    class TausendExpression : Expression
    {
        public override string Five()
        {
            return "";
        }

        public override string Four()
        {
            return "";
        }

        public override int Multiplier()
        {
            return 1000;
        }

        public override string Nine()
        {
            return "";
        }

        public override string One()
        {
            return "M";
        }
    }
}
