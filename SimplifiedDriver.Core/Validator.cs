using System.Linq;

namespace SimplifiedDriver.Core
{
    public class Validator
    {

        /// <summary>
        /// Checks all conditions 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>

        public static bool ValidatePacket(string command)
        {
            if (command.Length < 5) // "PT::E" contains 5 letters 
                return false;

            if (!command.StartsWith('P')) // the start of packet stream sequence is a ‚P’ character
                return false;

            int countColons = command.Count(x => x == ':'); // if commands contains less than 2 colons
            if (countColons < 2)
                return false;

            if (!Helper.commands.Contains(command[1])) // if command exist
                return false;

            if (command[2]!= ':') // PT: <--- 
                return false;

            foreach (var letter in command) // if command contains only ASCII
            {
                if (!letter.IsAcceptableValue())
                    return false;
            }
            return true;
        }
    }
}