using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            // Preprocess the string
            s = Preprocess(s);

            // Initialize our Two Pointers
            int start = 0;
            int end = s.Length - 1;

            // Compare the characters at the start and end of the string
            while (start < end)
            {
                // If the characters don't match, return false
                if (s[start] != s[end])
                {
                    return false;
                }

                // Move the pointers towards the center
                start++;
                end--;
            }

            // If all characters match, return true
            return true;
        }

        // Helper method to remove non alphanumeric characters from the string
        private string Preprocess(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToLower(c));
                }
            }
            return sb.ToString();
        }
    }
}
