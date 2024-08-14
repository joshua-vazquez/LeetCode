using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class RomanToIntegerTests
    {
        [Test]
        public void SimpleTest()
        {
            string roman = "III";
            int expected = 3;

            int result = RomanToInteger.RomanToInt(roman);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void MediumTest()
        {
            string roman = "LVIII";
            int expected = 58;

            int result = RomanToInteger.RomanToInt(roman);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void ComplexTest()
        {
            string roman = "MCMXCIV";
            int expected = 1994;

            int result = RomanToInteger.RomanToInt(roman);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SingleRomanNumeral()
        {
            string roman = "V";
            int expected = 5;

            int result = RomanToInteger.RomanToInt(roman);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestSubtractiveNotation()
        {
            string roman = "IX";
            int expected = 9;

            int result = RomanToInteger.RomanToInt(roman);

            Assert.That(expected, Is.EqualTo(result));
        }

        public void MostComplexTest()
        {
            string roman = "MMMDCCCLXXXVIII";
            int expected = 3888;

            int result = RomanToInteger.RomanToInt(roman);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
