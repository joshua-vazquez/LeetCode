using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MyMergeSort
    {
        public static void MergeSort(int[] arr)
        {
            // If the array is empty or has only one element, its already sorted
            if (arr.Length <= 1)
            {
                return;
            }

            // Find the middle index to split the array into two halves
            int mid = arr.Length / 2;

            //Create arrays for the left and right halves
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            // Copy the first half of the original array into the left array, and the same for the second half into the right
            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, arr.Length - mid);

            // Recursively sort of the left half and the right half
            MergeSort(left);
            MergeSort(right);

            // Merge the sorted halves back into one sorted array
            Merge(arr, left, right);
        }

        //Helper method to merge two sorted arrays into one sorted array
        private static void Merge(int[] arr, int[] left, int[] right)
        {
            // Initialize pointers for left, right, and original arrays
            int i = 0;
            int j = 0;
            int k = 0;

            // Compare elements from left and right arrays and merge them in sorted order
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];

                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            // Add any remaining elements from the left array to the original array
            while ( i < left.Length)
            {
                arr[k++] = left[i++];
            }

            // Add any remaining elements from the right array to the original array
            while ( j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }
    }
}
