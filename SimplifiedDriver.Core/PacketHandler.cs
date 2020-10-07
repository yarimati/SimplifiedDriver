using System;
using SimplifiedDriver.Core.Commands;

namespace SimplifiedDriver.Core
{
    public static class PacketHandler
    {

        /// <summary>
        /// Decide which command will be executed
        /// </summary>
        /// <param name="packet"></param>

        public static void Handler(string packet) 
        {
            bool isValidPacket = Validator.ValidatePacket(packet);

            if (isValidPacket)
            {
                switch (packet[1])
                {
                    case 'T':
                        TextCommand text = new TextCommand();
                        text.Execute(packet);
                        break;
                    case 'S':
                        SoundCommand sound = new SoundCommand();
                        sound.Execute(packet);
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n" + Helper.badRequest + "\n");
            }
        }
    }
}