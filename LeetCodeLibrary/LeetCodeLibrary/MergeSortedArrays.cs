namespace LeetCodeLibrary
{
    public class MergeSortedArrays
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Initialize three pointers
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            // Compare the elements of nums1 and nums2 and put the larger element at the end of nums1
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            // Copy any remaing elements from nums2 to nums1
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
