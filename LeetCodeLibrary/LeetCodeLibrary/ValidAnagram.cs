using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            // Check if the two strings are the same length
            if (s.Length != t.Length)
            {
                return false;
            }

            // Initialize the count dictionary
            Dictionary<char, int> count = new Dictionary<char, int>();

            // Iterates through the string s and maps it to the dictionary
            foreach (char c in s)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }

            // Iterates through the string t and decrements the count
            foreach (char c in t)
            {
                if (count.ContainsKey(c))
                {
                    count[c]--;

                    if (count[c] == 0)
                    {
                        count.Remove(c);
                    }
                }
                else
                {
                    return false;
                }
            }

            return count.Count == 0;
        }
    }
}
