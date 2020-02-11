using Command.Commandz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Invoker
{
    class User
    {
        Commands commands;
        public User(Commands command)
        {
            commands = command;
        }

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="Op"></param>
        /// <param name="x"></param>
        public void ExecuteCommand(string Op, int x)
        {
            Console.WriteLine($"Execute command for {Op} and {x}");
            commands.Execute(Op, x);
        }

        /// <summary>
        /// Undo the previous command
        /// </summary>
        public void UnDoCommand()
        {
            Console.WriteLine($"UnExecute command");
            commands.UnExecute();
        }
    }
}
