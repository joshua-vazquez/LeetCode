using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class LongestCommonPrefix
    {
        public string FindLongestCommonPrefix(string[] strs)
        {
            // If the input is null or empty, return an empty string
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            // Iterate through the characters of the first string
            for (int i = 0; i < strs[0].Length; i++)
            {
                // Get the character at the current index
                char c = strs[0][i];

                // Compare the character with the corresponding character in the other strings
                for (int j = 1; j < strs.Length; j++)
                {
                    // If the index is out of bounds or the characters don't match, return the prefix
                    if (i == strs[j].Length || strs[j][i] != c)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            // Return the first string if all characters match
            return strs[0];
        }
    }
}
