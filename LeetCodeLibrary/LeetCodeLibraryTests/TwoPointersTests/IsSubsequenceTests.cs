using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class IsSubsequenceTests
    {
        private IsSubsequence isSubsequence;
        [SetUp]
        public void SetUp()
        {
            isSubsequence = new IsSubsequence();
        }

        [Test]
        public void BasicTest()
        {
            string s = "abc";
            string t = "ahbgdc";
            bool expected = true;

            bool result = isSubsequence.FindSubsequence(s, t);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void BasicTest2() 
        {
            string s = "axc";
            string t = "ahbgdc";
            bool expected = false;

            bool result = isSubsequence.FindSubsequence(s, t);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void EmptyString()
        {
            string s = "";
            string t = "ahbgdc";
            bool expected = true;

            bool result = isSubsequence.FindSubsequence(s, t);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
