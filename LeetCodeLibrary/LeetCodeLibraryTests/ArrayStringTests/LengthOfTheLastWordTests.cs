using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class LengthOfTheLastWordTests
    {
        private LengthOfTheLastWord _lengthOfTheLastWord;

        [SetUp]
        public void SetUp()
        {
            _lengthOfTheLastWord = new LengthOfTheLastWord();
        }

        [Test]
        public void Test1()
        {
            string input = "Hello World";
            int expected = 5;
            
            int result = _lengthOfTheLastWord.LengthOfLastWord(input);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Test2()
        {
            string input = "  fly me  to  the moon  ";
            int expected = 4;

            int result = _lengthOfTheLastWord.LengthOfLastWord(input);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Test3()
        {
            string input = "luffy is still joyboy";
            int expected = 6;

            int result = _lengthOfTheLastWord.LengthOfLastWord(input);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestSingleWord()
        {
            string input = "Gamer";
            int expected = 5;

            int result = _lengthOfTheLastWord.LengthOfLastWord(input);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestEmptyString()
        {
            string input = "";
            int expected = 0;

            int result = _lengthOfTheLastWord.LengthOfLastWord(input);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
