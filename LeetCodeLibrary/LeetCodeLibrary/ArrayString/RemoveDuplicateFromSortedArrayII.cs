using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RemoveDuplicateFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
            {
                Console.WriteLine("Array length is less than or equal to 2. Returning length: " + nums.Length);
                return nums.Length;
            }

            int k = 2;
            Console.WriteLine("Initial k set to 2");

            for (int i = 2; i < nums.Length; i++)
            {
                Console.WriteLine("Iteration " + i + ": Comparing nums[" + i + "] = " + nums[i] + " with nums[" + (k - 2) + "] = " + nums[k - 2]);
                if (nums[i] != nums[k - 2])
                {
                    nums[k] = nums[i];
                    Console.WriteLine("nums[" + k + "] is now " + nums[i]);

                    k++;
                    Console.WriteLine("K incremented to " + k);
                }
            }
            Console.WriteLine("Final K: " + k);
            return k;
        }
    }
}
