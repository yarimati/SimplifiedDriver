using System;
using System.Text;
using SimplifiedDriver.Core;

namespace SimplifiedDriver.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder packet = new StringBuilder();

            while (true)
            {
                char input = Console.ReadKey().KeyChar;
                packet.Append(input);

                if (IsReadyPacket(packet))
                {
                    PacketHandler.Handler(packet.ToString());
                    packet.Clear();
                }
            }
        }

        /// <summary>
        /// Check if packet contains ":E" at the end
        /// </summary>
        /// <param name="packet"></param>
        /// <returns></returns>
        
        public static bool IsReadyPacket(StringBuilder packet)
        {
            if (packet.Length > 4)
            {
                if (packet[^2] == ':' &&
                    packet[^1] == 'E')
                    return true;
            }
            return false;
        }
    }
}

