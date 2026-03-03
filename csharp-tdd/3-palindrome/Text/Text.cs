using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            string cleaned = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                    cleaned += char.ToLower(c);
            }

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}
