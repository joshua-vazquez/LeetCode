using NUnit.Framework;
using static LeetCodeLibrary.BestTimeToBuyAndSellStock;

namespace LeetCodeLibraryTests
{
    public class BestTimeToBuyAndSellStockTests
    {
        [Test]
        public void TestExample1()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int expected = 5;
            int result = MaxProfit(prices);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestExample2()
        {
            int[] prices = { 7, 6, 4, 3, 1 };
            int expected = 0;
            int result = MaxProfit(prices);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestSingleDay()
        {
            int[] prices = { 5 };
            int expected = 0;
            int result = MaxProfit(prices);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestNoProfit()
        {
            int[] prices = { 3, 3, 3, 3, 3 };
            int expected = 0;
            int result = MaxProfit(prices);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestIncreasingPrices()
        {
            int[] prices = { 1, 2, 3, 4, 5 };
            int expected = 4;
            int result = MaxProfit(prices);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestDecreasingPrices()
        {
            int[] prices = { 5, 4, 3, 2, 1 };
            int expected = 0;
            int result = MaxProfit(prices);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}