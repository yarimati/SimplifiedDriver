namespace SimplifiedDriver.Core
{
    public static class CharExtension
    {

        /// <summary>
        /// Packet contains only ASCII characters in range 32-127.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public static bool IsAcceptableValue(this char value)
        {
            return value > 31 && value < 128;
        }
    }
}