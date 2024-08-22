using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class CountCompleteTreeNodesTests
    {
        [Test]
        public void TestCountNodes1()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), null));

            int result = new CountCompleteTreeNodes().CountNodes(root);
            int expected = 6;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestCountNodes2()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), new TreeNode(7)));

            int result = new CountCompleteTreeNodes().CountNodes(root);
            int expected = 7;

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void TestCountNodes3()
        {
            TreeNode root = new TreeNode(1);

            int result = new CountCompleteTreeNodes().CountNodes(root);
            int expected = 1;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestCountNodes4()
        {
            TreeNode root = null;

            int result = new CountCompleteTreeNodes().CountNodes(root);
            int expected = 0;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
