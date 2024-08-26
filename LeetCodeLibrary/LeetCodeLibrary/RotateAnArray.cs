using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeLibrary
{
    public class RotateAnArray
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k == 0)
            {
                return;
            }

            k = k % nums.Length;
            Console.WriteLine("After handling large k, k = " + k);

            Console.WriteLine("Array before reversing the entire array: " + string.Join(", ", nums));
            Reverse(nums, 0, nums.Length - 1);
            Console.WriteLine("Array after reversing the entire array: " + string.Join(", ", nums));

            Console.WriteLine("Array before reversing the first " + k + " elements: " + string.Join(", ", nums));
            Reverse(nums, 0, k - 1);
            Console.WriteLine("Array after reversing the first " + k + " elements: " + string.Join(", ", nums));

            Console.WriteLine("Array before reversing the remaining elements from " + k + " to " + (nums.Length - 1) + ": " + string.Join(", ", nums));
            Reverse(nums, k, nums.Length - 1);
            Console.WriteLine("Array after reversing the remaining elements: " + string.Join(", ", nums));
        }

        private void Reverse(int[] array, int start, int end)
        {
            Console.WriteLine("Reversing from index " + start + " to " + end);
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                Console.WriteLine("Swapped elements at index " + start + " and " + end + ": " + string.Join(", ", array));

                start++;
                end--;
            }
        }
    }
}
