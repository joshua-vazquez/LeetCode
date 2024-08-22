using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class TreeNode3
    {
        public int val;
        public TreeNode3 left;
        public TreeNode3 right;
        public TreeNode3(int val = 0, TreeNode3 left = null, TreeNode3 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode3 root)
        {
            return IsMirror(root, root);
        }

        private bool IsMirror(TreeNode3 node1, TreeNode3 node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            if (node1 == null || node2 == null)
            {
                return false;
            }
            return (node1.val == node2.val) && IsMirror(node1.right, node2.left) && IsMirror(node1.left, node2.right);
        }
    }
}
