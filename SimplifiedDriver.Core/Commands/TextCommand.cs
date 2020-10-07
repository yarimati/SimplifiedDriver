using System;
using SimplifiedDriver.Core.Abstractions;

namespace SimplifiedDriver.Core.Commands
{
    public class TextCommand : ConsoleCommand
    {

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="command"></param>

        public override void Execute(string command)
        {
            var output = Helper.ExtractCommand(command);
            Console.Write("\n" + Helper.goodRequest + "\n" + output + "\n\n");
        }
    }
}