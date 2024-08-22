using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class ContainsDuplicateTwoTests
    {
        [Test]
        public void Test1()
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;

            bool expected = true;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            int[] nums = { 1, 0, 1, 1 };
            int k = 1;

            bool expected = true;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;

            bool expected = false;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestNoDuplicates()
        {
            int[] nums = { 1, 2, 3, 4 };
            int k = 1;

            bool expected = false;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestDuplicatesFarApart()
        {
            int[] nums = { 1, 2, 3, 4, 1, 2, 3, 4 };
            int k = 1;

            bool expected = false;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestEmptyArray()
        {
            int[] nums = { };
            int k = 1;

            bool expected = false;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestSingleElement()
        {
            int[] nums = { 1 };
            int k = 1;

            bool expected = false;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestLargeK()
        {
            int[] nums = { 1, 2, 3, 1 };
            int k = 10;

            bool expected= true;
            bool result = new ContainsDuplicateTwo().ContainsNearbyDuplicate(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
