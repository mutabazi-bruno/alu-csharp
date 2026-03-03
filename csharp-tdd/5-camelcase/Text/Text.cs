using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string
        /// </summary>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 1;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    count++;
            }

            return count;
        }
    }
}
