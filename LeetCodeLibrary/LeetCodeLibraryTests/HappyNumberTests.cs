using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class HappyNumberTests
    {
        [Test]
        public void TestTrue()
        {
            int n = 19;

            bool result = new HappyNumber().IsHappy(n);

            Assert.That(result, Is.True);
        }

        [Test]
        public void TestFalse()
        {
            int n = 2;

            bool result = new HappyNumber().IsHappy(n);

            Assert.That(result, Is.False);
        }
    }
}
