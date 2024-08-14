using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            // Create a dictionary to map roman numerals to integers
            Dictionary<char, int> romanMap = new Dictionary<char, int>
            { 
                { 'I', 1},
                { 'V', 5},
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}
            };

            // Initialize a variable to store the total
            int total = 0;

            // Iterate through the string
            for (int i = 0; i < s.Length; i++)
            {
                // If the current roman numeral is less than the next one, subtract it from the total
                if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    total -= romanMap[s[i]];
                }
                // Otherwise, add it to the total
                else
                {
                    total += romanMap[s[i]];
                }
            }
            // Return the total
            return total;
        }
    }
}
