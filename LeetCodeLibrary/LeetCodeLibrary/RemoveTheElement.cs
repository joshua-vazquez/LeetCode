using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RemoveTheElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k++] = nums[i];
                }
            }
            return k;
        }
    }
}
