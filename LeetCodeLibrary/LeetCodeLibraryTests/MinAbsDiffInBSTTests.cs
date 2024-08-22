using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class MinAbsDiffInBSTTests
    {
        [Test]
        public void Test1()
        {
            TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6));
            int expected = 1;

            int result = new MinAbsDiffInBST().GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            TreeNode root = new TreeNode(1, new TreeNode(0), new TreeNode(48, new TreeNode(12), new TreeNode(49)));
            int expected = 1;

            int result = new MinAbsDiffInBST().GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestSingleNode()
        {
            TreeNode root = new TreeNode(1);
            int expected = int.MaxValue;

            int result = new MinAbsDiffInBST().GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestTwoNodes()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(3));
            int expected = 2;

            int result = new MinAbsDiffInBST().GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestLargeTree()
        {
            TreeNode root = new TreeNode(10, new TreeNode(5, new TreeNode(2), new TreeNode(7)), new TreeNode(15, new TreeNode(12), new TreeNode(20)));
            int expected = 2;

            int result = new MinAbsDiffInBST().GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
