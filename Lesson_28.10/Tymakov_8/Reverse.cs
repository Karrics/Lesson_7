using System;

namespace Tymakov_8
{
    internal class Reverse
    {
        public static string Reversed(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
