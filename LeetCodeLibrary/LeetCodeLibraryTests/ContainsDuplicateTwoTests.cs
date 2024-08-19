using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class ContainsDuplicateTwoTests
    {
        [Test]
        public void TestTrue()
        {
            int k = 2;
            int[] nums = { 1, 2, 3, 1 };

            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.True);
        }

        [Test]
        public void TestFalse()
        {
            int k = 3;
            int[] nums = { 1, 2, 3, 1, 2, 3 };

            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.False);
        }
    }
}
