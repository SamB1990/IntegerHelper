namespace System
{
    /// <summary>
    /// Integer parity Extensions class
    /// </summary>
    public static class ParityExtensions
    {
        /// <summary>
        /// Checks if a number is even
        /// </summary>
        /// <param name="input">the number you wish to assess</param>
        /// <returns>result of if the input number even</returns>
        public static bool IsEven(this int input)
        {
            return (input % 2 == 0);
        }


        /// <summary>
        /// Rounds an integer either up or down to the nearest even number
        /// </summary>
        /// <param name="input">the integer that you wish to make even</param>
        /// <param name="roundUp">should the integer be round up or down to the nearest even integer</param>
        /// <returns></returns>
        public static int ToEven(this int input, bool roundUp = true)
        {
            return input.IsEven() ? input : (roundUp ? ++input : --input);
        }

        /// <summary>
        /// Rounds an integer either up or down to the nearest odd number
        /// </summary>
        /// <param name="input">the integer that you wish to make odd</param>
        /// <param name="roundUp">should the integer be round up or down to the nearest odd integer</param>
        /// <returns></returns>
        public static int ToOdd(this int input, bool roundUp = true)
        {
            return !input.IsEven() ? input : (roundUp ? ++input : --input);
        }
    }
}
