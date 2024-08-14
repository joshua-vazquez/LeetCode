using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class NeedleInAHaystackTests
    {
        private NeedleInAHaystack needleInAHaystack;

        [SetUp]
        public void SetUp()
        {
            needleInAHaystack = new NeedleInAHaystack();
        }

        [Test]
        public void BasicTest()
        {
            string haystack = "hello";
            string needle = "ll";
            int expected = 2;

            int result = needleInAHaystack.StrStr(haystack, needle);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void NeedleNotFound ()
        {
            string haystack = "aaaaa";
            string needle = "bba";
            int expected = -1;

            int result = needleInAHaystack.StrStr(haystack, needle);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void EmptyNeedle()
        {
            string haystack = "hello";
            string needle = "";
            int expected = 0;

            int result = needleInAHaystack.StrStr(haystack, needle);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void HaystackShorterThanNeedle()
        {
            string haystack = "short";
            string needle = "longerneedle";
            int expected = -1;

            int result = needleInAHaystack.StrStr(haystack, needle);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void HaystackAndNeedleAreEqual()
        {
            string haystack = "equal";
            string needle = "equal";
            int expected = 0;

            int result = needleInAHaystack.StrStr(haystack, needle);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void NeedleAtBeginning()
        {
            string haystack = "start";
            string needle = "sta";
            int expected = 0;

            int result = needleInAHaystack.StrStr(haystack, needle);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void NeedleAtEnd()
        {
            string haystack = "ending";
            string needle = "ing";
            int expected = 3;

            int result = needleInAHaystack.StrStr(haystack, needle);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
