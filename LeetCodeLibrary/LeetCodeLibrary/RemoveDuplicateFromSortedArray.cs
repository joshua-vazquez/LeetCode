using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RemoveDuplicateFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            //If the array is empty return 0
            if ( nums.Length == 0)
            {
                return 0;
            }

            // Initialize a pointer k to 0 to track the position of the last unique element
            int k = 0;

            // Iterate through the array starting from the second element
            for (int  j = 1;  j < nums.Length;  j++)
            {
                // If the current element is different from the last unique element 
                if (nums[j] != nums[k])
                {
                    k++; // move the pointer k to the next position
                    nums[k] = nums[j]; //Update the element at position k to the current element
                }
            }
            // Return the number of unique elements, which is k + 1
            return k + 1;
        }
    }
}
