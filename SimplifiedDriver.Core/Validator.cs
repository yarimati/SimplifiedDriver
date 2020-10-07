using System.Linq;

namespace SimplifiedDriver.Core
{
    public class Validator
    {

        /// <summary>
        /// Checks all conditions 
        /// </summary>
        /// <param name="packet"></param>
        /// <returns></returns>

        public static bool ValidatePacket(string packet)
        {
            if (packet.Length < 5) // "PT::E" contains 5 letters 
                return false;

            if (!packet.StartsWith('P')) // the start of packet stream sequence is a ‚P’ character
                return false;

            int countColons = packet.Count(x => x == ':'); // if commands contains less than 2 colons
            if (countColons < 2)
                return false;

            if (!Helper.commands.Contains(packet[1])) // if command exist
                return false;

            if (packet[2]!= ':') // PT: <--- 
                return false;

            foreach (var letter in packet) // if command contains only ASCII
            {
                if (!letter.IsAcceptableValue())
                    return false;
            }
            return true;
        }
    }
}