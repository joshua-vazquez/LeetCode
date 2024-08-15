using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class IsSubsequence
    {
        public bool FindSubsequence(string s, string t)
        {
            /*Initialize both of our pointers
           int i = 0;
           int j = 0;

            Loop through the strings while i is less than the length of s and j is less than the length of t
           while ( i < s.Length && j < t.Length)
           {
                If the characters at the current index of s and t match, increment i
               if (s[i] == t[j])
               {
                   i++;
               }
                We always increment j to move through t
               j++;
           }
            If i is equal to the length of s, we have found a subsequence
           return i == s.Length;*/


            // Preprocess the string t
            var charPositions = new Dictionary<char, List<int>>();
            for (int i = 0; i < t.Length; i++)
            {
                if (!charPositions.ContainsKey(t[i]))
                {
                    charPositions[t[i]] = new List<int>();
                }
                charPositions[t[i]].Add(i);
            }

            // Check each character of s
            int prevPosition = -1;
            foreach (char c in s)
            {
                if (!charPositions.ContainsKey(c))
                {
                    return false;
                }

                var positions = charPositions[c];
                int nextPosition = BinarySearch(positions, prevPosition);

                if (nextPosition == -1)
                {
                    return false;
                }
                prevPosition = nextPosition;
            }
            return true;
        }

        // Create a helper method to perform a binary search on the list of positions
        private int BinarySearch(List<int> positions, int prevPosition)
        {
            int left = 0;
            int right = positions.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (positions[mid] <= prevPosition)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left < positions.Count ? positions[left] : -1;
        }
    }
}