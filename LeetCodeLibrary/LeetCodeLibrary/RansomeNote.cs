using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RansomeNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            // Initializa a dictionary to count the frequency of each character in the magazine
            var charCount = new Dictionary<char, int>();

            // Count the frequency of each character in the magazine
            foreach (char c in magazine)
            {
                if (!charCount.ContainsKey(c))
                {
                    charCount[c] = 0;
                }
                charCount[c]++;
            }

            // Check if the ransomNote can be constructed
            foreach (char c in ransomNote)
            {
                if (!charCount.ContainsKey(c) || charCount[c] == 0)
                {
                    return false;
                }
                charCount[c]--;
            }
            return true;
        }
    }
}
