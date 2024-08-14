using NUnit.Framework;
using LeetCodeLibrary;


namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class ValidPalindromeTests
    {
        private ValidPalindrome validPalindrome;

        [SetUp]
        public void SetUp()
        {
            validPalindrome = new ValidPalindrome();    
        }

        [Test]
        public void BasicTest()
        {
            string s = "racecar";

            bool result = validPalindrome.IsPalindrome(s);

            Assert.That(result, Is.True);
        }

        [Test]
        public void NonPalindrome()
        {
            string s = "hello";

            bool result = validPalindrome.IsPalindrome(s);

            Assert.That(result, Is.False);
        }

        [Test]
        public void EmptyString()
        {
            string s = "";

            bool result = validPalindrome.IsPalindrome(s);

            Assert.That(result, Is.True);
        }

        [Test]
        public void SingleCharacter()
        {
            string s = "a";

            bool result = validPalindrome.IsPalindrome(s);

            Assert.That(result, Is.True);
        }

        [Test]
        public void NonAlphanumericCharacters()
        {
            string s = "A man, a plan, a canal: Panama";

            bool result = validPalindrome.IsPalindrome(s);

            Assert.That(result, Is.True);
        }

        [Test]
        public void MixedCasePalindrome()
        {
            string s = " Able was I ere I saw Elba";

            bool result = validPalindrome.IsPalindrome(s);

            Assert.That(result, Is.True);
        }

    }
}
