using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class AverageOfLevelsInBinaryTreeTests
    {
        [Test]
        public void Test1()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var result = new AverageOfLevelsInBinaryTree().AverageOfLevels(root);
            double[] expected = { 3.0, 14.5, 11.0 };

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            var result = new AverageOfLevelsInBinaryTree().AverageOfLevels(root);
            double[] expected = { 1.0, 2.5, 5.5 };

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            TreeNode root = null;

            var result = new AverageOfLevelsInBinaryTree().AverageOfLevels(root);
            double[] expected = { };

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
