using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class PathSumTests
    {
        [Test]
        public void TestPathSum1()
        {
            TreeNode root = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2)), null), new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1))));
            int targetSum = 22;

            bool result = new PathSum().HasPathSum(root, targetSum);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void TestPathSum2()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            int targetSum = 5;

            bool result = new PathSum().HasPathSum(root, targetSum);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestPathSum3()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2));
            int targetSum = 1;

            bool result = new PathSum().HasPathSum(root, targetSum);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestPathSum4()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2));
            int targetSum = 3;

            bool result = new PathSum().HasPathSum(root, targetSum);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
