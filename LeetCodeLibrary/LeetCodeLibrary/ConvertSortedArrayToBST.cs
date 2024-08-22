using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ConvertSortedArrayToBST
    {
        // Method to convert a sorted array to a height balanced BST
        public TreeNode SortedArrayToBST(int[] nums)
        {
            // Call the helper method to build the BST
            return BuildBST(nums, 0, nums.Length - 1);
        }

        // Helper method to recursively build the BST
        private TreeNode BuildBST(int[] nums, int left, int right)
        {
            // Base case: If the left index is greater than the right index, return null
            if (left > right)
            {
                return null;
            }

            // Calculate the middle index to make it the root
            int mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(nums[mid]);

            // Recursively build the left subtree
            node.left = BuildBST(nums, left, mid - 1);

            // Recursively build the right subtree
            node.right = BuildBST(nums, mid + 1, right);

            // Return the current node as the root of this subtree
            return node;
        }
    }
}
