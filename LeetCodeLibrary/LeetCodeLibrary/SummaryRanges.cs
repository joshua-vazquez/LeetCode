using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SummaryRanges
    {
        public static IList<string> GetRanges(int[] nums)
        {
            List<string> ranges = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                int start = nums[i];
                while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
                {
                    i++;
                }

                int end = nums[i];
                if (start == end)
                {
                    ranges.Add(start.ToString());
                }
                else
                {
                    ranges.Add(start + "->" + end);
                }
            }
            return ranges;
        }
    }
}
