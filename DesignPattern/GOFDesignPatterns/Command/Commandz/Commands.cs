using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commandz
{
    /// <summary>
    /// Command class
    /// </summary>
    public interface Commands
    {
        void Execute(string Op, int x);
        void UnExecute();
    }
}
