using System.Collections.Generic;
using System.IO;

namespace SimplifiedDriver.Core
{
    public class Helper
    {
        public static readonly List<char> commands;
        public const string goodRequest = "Status ACK ";
        public const string badRequest = "Status NACK ";

        /// <summary>
        /// Initialize commands only once
        /// </summary>
        
        static Helper()
        {
            commands = new List<char>();
            commands.Add('T'); // TextCommand
            commands.Add('S'); // SoundCommand

            //var firstLetterCommands = GetAllCommands();
            //commands = firstLetterCommands; // to automatically add commands from folder
        }

        /// <summary>
        /// Takes from packet only property
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>

        public static string ExtractCommand(string command)
        {
            return command.Substring(3, command.Length - 5);
        }

        /// <summary>
        /// Get all commands from Commands folder and
        /// returns a collection of the first letters of the commands
        /// </summary>
        /// <returns></returns>
        private static List<char> GetAllCommands()
        {
            string[] existingCommands = Directory.GetFiles(@"C:\Users\nikim\source\repos\SimplifiedDriver\SimplifiedDriver.Core\Commands\");

            List<char> commands = new List<char>();

            foreach (var command in existingCommands)
            {
                if (command.Length > 0)
                    commands.Add(commands[0]);
            }

            return commands;
        }

    }
}