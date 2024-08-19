using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            // Store all the numbers we have already seen
            HashSet<int> seen = new HashSet<int>();

            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = SumOfSquares(n);
            }

            return n == 1;
        }

        private int SumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            return sum;
        }
    }
}
