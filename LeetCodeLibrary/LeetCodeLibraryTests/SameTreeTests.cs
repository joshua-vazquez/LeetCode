using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class SameTreeTests
    {
        [Test]
        public void TestSameTree()
        {
            TreeNode2 p = new TreeNode2(1, new TreeNode2(2), new TreeNode2(3));
            TreeNode2 q = new TreeNode2(1, new TreeNode2(2), new TreeNode2(3));

            bool result = new SameTree().IsSameTree(p, q);

            Assert.That(result, Is.True);
        }

        [Test]
        public void TestDifferentStructure()
        {
            TreeNode2 p = new TreeNode2(1, new TreeNode2(2), null);
            TreeNode2 q = new TreeNode2(1, null, new TreeNode2(2));

            bool result = new SameTree().IsSameTree(p, q);

            Assert.That(result, Is.False);
        }

        [Test]
        public void TestDifferentValues()
        {
            TreeNode2 p = new TreeNode2(1, new TreeNode2(2), new TreeNode2(1));
            TreeNode2 q = new TreeNode2(1, new TreeNode2(1), new TreeNode2(2));

            bool result = new SameTree().IsSameTree(p, q);

            Assert.That(result, Is.False);
        }

        [Test]
        public void TestBothNull()
        {
            TreeNode2 p = null;
            TreeNode2 q = null;

            bool result = new SameTree().IsSameTree(p, q);

            Assert.That(result, Is.True);
        }

        [Test]
        public void TestOneNull()
        {
            TreeNode2 p = new TreeNode2(1);
            TreeNode2 q = null;

            bool result = new SameTree().IsSameTree(p, q);

            Assert.That(result, Is.False);
        }
    }
}
