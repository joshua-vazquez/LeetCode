using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NeedleInAHaystack
    {
        public int StrStr(string haystack, string needle)
        {
            // If the needle is in an empty string, return 0
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            // If the haystack is shorter than the needle, return -1
            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            // Iterate through the haystack with a window of the same length as the needle
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                // Check if the substring of the haystack matches the needle
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            // If the needle is not found, return -1
            return -1;
        }
    }
}
