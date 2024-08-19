using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ContainsDuplicateTwo
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            // Initialize the HashSet for storing the elements within the current window of size k
            HashSet<int> lastSeen = new HashSet<int>();


            // Iterate though each element in the array
            for (int i = 0; i < nums.Length; i++)
            {

                // Check if the element is already in the HashSet
                if (lastSeen.Contains(nums[i]))
                {
                    return true;
                }

                // Add the element to the HashSet
                lastSeen.Add(nums[i]);

                // Remove the element that is outside the window
                if (lastSeen.Count > k)
                {
                    lastSeen.Remove(nums[i - k]);
                }
            }
            // If no duplicates are found, return false
            return false;
        }
    }
}
