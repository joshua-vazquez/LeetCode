using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MajorityElement
    {
        public int FindMajorityElement(int[] nums)
        {
            // Initialize variables and iterate through the array using a Boyer-Moore voting algorithm
            int count = 0;
            int candidate = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num; // Set the candidate to the current element
                }
                if (num == candidate)
                {
                    count++; // Increment the count if the current element is the same as the candidate
                }
                else
                {
                    count--; // Decrement the count if the current element is different from the candidate
                }
            }
            return candidate; // Return the majority element
        }
    }
}
