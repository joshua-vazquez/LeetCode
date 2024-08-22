using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class ConvertSortedArrayToBSTTests
    {
        [Test]
        public void Test1()
        {
            int[] nums = { -10, -3, 0, 5, 9 };

            TreeNode result = new ConvertSortedArrayToBST().SortedArrayToBST(nums);

            Assert.That(result.val, Is.EqualTo(0));
            Assert.That(result.left.val, Is.EqualTo(-10));
            Assert.That(result.right.val, Is.EqualTo(5));
        }

        [Test]
        public void Test2()
        {
            int[] nums = { 1, 3 };

            TreeNode result = new ConvertSortedArrayToBST().SortedArrayToBST(nums);

            Assert.IsNotNull(result);
            Assert.That(result.val, Is.EqualTo(1));
            Assert.That(result.right.val, Is.EqualTo(3));
        }


        [Test]
        public void TestSingleElement()
        {
            int[] nums = { 1 };

            TreeNode result = new ConvertSortedArrayToBST().SortedArrayToBST(nums);

            Assert.IsNotNull(result);
            Assert.That(result.val, Is.EqualTo(1));
            Assert.IsNull(result.left);
            Assert.IsNull(result.right);
        }

        [Test]
        public void TestEmptyArray()
        {
            int[] nums = { };

            TreeNode result = new ConvertSortedArrayToBST().SortedArrayToBST(nums);

            Assert.IsNull(result);
        }

        [Test]
        public void TestLargeArray()
        {
            int[] nums = { -10, -3, 0, 5, 9, 12, 15 };

            TreeNode result = new ConvertSortedArrayToBST().SortedArrayToBST(nums);

            Assert.IsNotNull(result);
            Assert.IsTrue(IsValidBST(result));

        }

        private bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, int.MinValue, int.MaxValue);
        }

        private bool IsValidBST(TreeNode node, int min, int max)
        {
            if (node == null) return true;
            if (node.val <= min || node.val >= max) return false;
            return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
        }
    }
}
