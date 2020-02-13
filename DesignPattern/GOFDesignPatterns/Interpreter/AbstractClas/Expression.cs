using Interpreter.Features;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.AbstractClas
{
    /// <summary>
    /// Abstract expression
    /// </summary>
    abstract class Expression
    {
        public void Interpret(Context context)
        {
            if(context.Input.Length == 0)
            {
                return;
            }

            if (context.Input.StartsWith(Nine()))
            {
                context.OutPut += 9 * Multiplier();
                context.Input = context.Input.Substring(2);
            } else if(context.Input.StartsWith(Four()))
            {
                context.OutPut += 4 * Multiplier();
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.OutPut += 5 * Multiplier();
                context.Input = context.Input.Substring(1);
            }
            else if (context.Input.StartsWith(One()))
            {
                context.OutPut += 1 * Multiplier();
                context.Input = context.Input.Substring(1);
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();

        public abstract string Nine();
        public abstract int Multiplier();

    }
}
