using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class LengthOfTheLastWord
    {
        public int LengthOfLastWord(string s)
        {
            s = CustomTrim(s); // Remove leading and trailing spaces
            string[] words = CustomSplit(s, ' '); // Split the string by spaces

            if (words.Length == 0) // If there are no words, return 0
            {
                return 0;
            }

            return words[words.Length - 1].Length; // Return the length of the last word
        }

        public string CustomTrim(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start <= end && s[start] == ' ')
            {
                start++; // Move the start index to the right until it reaches a non-space character
            }

            while (end >= start && s[end] == ' ')
            {
                end--;  // Move the end index to the left until it reaches a non-space character
            }

            return s.Substring(start, end - start + 1); // Return the substring between the start and end indices
        }

        public static string[] CustomSplit(string s, char separator)
        {
            List<string> result = new List<string>();   // Create a list to store the words
            StringBuilder currentWord = new StringBuilder();  // Create a StringBuilder to build the current word

            foreach (char c in s)
            {
                if (c == separator)
                {
                    if (currentWord.Length > 0)
                    {
                        result.Add(currentWord.ToString()); // Add the current word to the list
                        currentWord.Clear();  // Clear the StringBuilder
                    }
                    
                }
                else
                {
                    currentWord.Append(c); // Append the character to the current word
                }
            }

            if (currentWord.Length > 0)
            {
                result.Add(currentWord.ToString()); // Add the last word to the list
            }  

            return result.ToArray(); // Return the list as an array
        }
    }
}
