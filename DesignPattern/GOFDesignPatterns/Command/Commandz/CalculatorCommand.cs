using Command.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commandz
{
    /// <summary>
    /// Concrete command class
    /// </summary>
    public class CalculatorCommand : Commands
    {
        Calculator calculator = new Calculator();

        public string Operator { get; set; }
        public int operand { get; set; }

        public int Result { get; set; }
        public void Execute(string Op, int x)
        {
            Operator = Op;
            operand = x;
            Result = calculator.Operation(Op, x);
        }

        /// <summary>
        /// Keep the previous in property
        /// </summary>
        public void UnExecute()
        {
            Result = calculator.Operation(Undo(), operand, Result);
        }

        private string Undo()
        {
            switch(Operator)
            {
                case "+": return "-";
                case "-": return "+";
                case "*": return "/";
                case "/": return "*";
                default:
                    return "";
            }
        }
    }
}
