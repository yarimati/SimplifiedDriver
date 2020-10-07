using System;
using SimplifiedDriver.Core.Abstractions;

namespace SimplifiedDriver.Core.Commands
{
    public class SoundCommand : ConsoleCommand
    {

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="command"></param>

        public override void Execute(string command)
        {
            var output = Helper.ExtractCommand(command);

            try
            {
                string[] values = output.Split(new[] {','});

                int freq = Convert.ToInt32(values[0]);
                int dur = Convert.ToInt32(values[1]);

                Console.WriteLine("\n" + Helper.goodRequest + "\n");
                Console.Beep(freq, dur);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\n" + Helper.badRequest + "\n");
            }
        }
    }
}