using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ConvertSortedArrayToBST
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return BuildBST(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildBST(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = BuildBST(nums, left, mid - 1);
            node.right = BuildBST(nums, mid + 1, right);

            return node;
        }
    }
}
