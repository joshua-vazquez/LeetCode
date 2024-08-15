using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class RansomeNoteTests
    {
        private RansomeNote ransomeNote;

        [SetUp]
        public void SetUp()
        {
            ransomeNote = new RansomeNote();
        }

        [Test]
        [TestCase("a", "b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        [TestCase("a", "a", true)]
        [TestCase("", "aab", true)]
        [TestCase("a", "", false)]
        [TestCase("", "", true)]
        [TestCase("aab", "aab", true)]
        [TestCase("aabb", "aab", false)]
        public void TestRansomeNote(string ransomNote, string magazine, bool expected)
        {
            bool result = ransomeNote.CanConstruct(ransomNote, magazine);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
