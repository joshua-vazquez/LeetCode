using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinAbsDiffInBST
    {
        private int minDiff = int.MaxValue;
        private TreeNode prev = null;

        public int GetMinimumDifference(TreeNode root)
        {
            InorderTraversal(root);
            return minDiff;
        }

        private void InorderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversal(node.left);

            if (prev != null)
            {
                int diff = node.val - prev.val;
                Console.WriteLine($"Current Node: {node.val}, Previous Node: {prev.val}, Difference: {diff}");
                minDiff = Math.Min(minDiff, diff);
            }
            prev = node;

            InorderTraversal(node.right);
        }
    }
}
