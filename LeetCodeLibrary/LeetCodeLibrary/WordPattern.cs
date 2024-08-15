using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class WordPattern
    {
        public bool IsThereAPAttern(string pattern, string s)
        {
            // Split the string into words
            var words = s.Split(' ');

            // Check if the pattern and the words have the same length
            if (pattern.Length != words.Length)
            {
                return false;
            }

            // Initialize the maps(aka dictionaries)
            var mapCharToWord = new Dictionary<char, string>();
            var mapWordToChar = new Dictionary<string, char>();

            // Check if the pattern and the words match
            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];
                string word = words[i];

                if (mapCharToWord.ContainsKey(c))
                {
                    if (mapCharToWord[c] != word)
                    {
                        return false;
                    }
                }
                else
                {
                    mapCharToWord[c] = word;
                }

                if (mapWordToChar.ContainsKey(word))
                {
                    if (mapWordToChar[word] != c)
                    {
                        return false;
                    }
                }
                else
                {
                    mapWordToChar[word] = c;
                }
            }

            // If the pattern and the words match, return true
            return true;
        }
    }
}