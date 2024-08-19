using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class SummaryRangesTests
    {
        [Test]
        public void Test1()
        {
            int[] nums = { 0, 1, 2, 4, 5, 7 };

            IList<string> expected = new List<string> { "0->2", "4->5", "7" };
            IList<string> result = SummaryRanges.GetRanges(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestExample2()
        {
            int[] nums = { 0, 2, 3, 4, 6, 8, 9 };

            IList<string> expected = new List<string> { "0", "2->4", "6", "8->9" };
            IList<string> result = SummaryRanges.GetRanges(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestSingleElement()
        {
            int[] nums = { 1 };

            IList<string> expected = new List<string> { "1" };
            IList<string> result = SummaryRanges.GetRanges(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestEmptyArray()
        {
            int[] nums = { };

            IList<string> expected = new List<string> { };
            IList<string> result = SummaryRanges.GetRanges(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestConsecutiveNumbers()
        {
            int[] nums = { 1, 2, 3, 4, 5 };

            IList<string> expected = new List<string> { "1->5" };
            IList<string> result = SummaryRanges.GetRanges(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestNonConsecutiveNumbers()
        {
            int[] nums = { 1, 3, 5, 7, 9 };

            IList<string> expected = new List<string> { "1", "3", "5", "7", "9" };
            IList<string> result = SummaryRanges.GetRanges(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
