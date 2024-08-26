using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int  i = 0;  i < prices.Length;  i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    Console.WriteLine($" current price: {prices[i]}, minPrice: {minPrice}");
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                  maxProfit = prices[i] - minPrice;
                    Console.WriteLine($" current price: {prices[i]}, minPrice: {minPrice}, maxProfit: {maxProfit}");
                }
            }
            return maxProfit;
        }
    }
}
