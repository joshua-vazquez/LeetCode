using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int step = 0;
            Console.WriteLine("Initial step: " + step);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Index: " + i + ", Value: " + nums[i] + ", Current step: " + step);

                if (i > step)
                {
                    Console.WriteLine("Cannot reach index " + i + " with current step " + step);
                    return false;
                }
                step = Math.Max(step, i + nums[i]);
                Console.WriteLine("Updated step after index " + i + ": " + step);
            }
            Console.WriteLine("Reached the end of the array");
            return true;
        }
    }
}
