using Interpreter.AbstractClas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Features.Expressions
{
    class OneExpression : Expression
    {
        public override string Five()
        {
            return "V";
        }

        public override string Four()
        {
            return "IV";
        }

        public override int Multiplier()
        {
            return 1;
        }

        public override string Nine()
        {
            return "IX";
        }

        public override string One()
        {
            return "I";
        }
    }
}
