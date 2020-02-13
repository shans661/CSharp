using Interpreter.AbstractClas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Features.Expressions
{
    /// <summary>
    /// Concrete expression
    /// </summary>
    class TenExpression : Expression
    {
        public override string Five()
        {
            return "L";
        }

        public override string Four()
        {
            return "XL";
        }

        public override int Multiplier()
        {
            return 10;
        }

        public override string Nine()
        {
            return "XC";
        }

        public override string One()
        {
            return "X";
        }
    }
}
