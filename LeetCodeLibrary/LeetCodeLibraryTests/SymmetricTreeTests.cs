using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class SymmetricTreeTests
    {
        [Test]
        public void TestSymmetricTree1()
        {
            TreeNode3 root = new TreeNode3(1, new TreeNode3(2, new TreeNode3(3), new TreeNode3(4)), new TreeNode3(2, new TreeNode3(4), new TreeNode3(3)));

            bool result = new SymmetricTree().IsSymmetric(root);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void TestSymmetricTree2()
        {
            TreeNode3 root = new TreeNode3(1, new TreeNode3(2, null, new TreeNode3(3)), new TreeNode3(2, null, new TreeNode3(3)));

            bool result = new SymmetricTree().IsSymmetric(root);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestSymmetricTree3()
        {
            TreeNode3 root = new TreeNode3(1);

            bool result = new SymmetricTree().IsSymmetric(root);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void TestSymmetricTree4()
        {
            TreeNode3 root = new TreeNode3(1, new TreeNode3(2, new TreeNode3(3), null), new TreeNode3(2, null, new TreeNode3(3)));

            bool result = new SymmetricTree().IsSymmetric(root);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
