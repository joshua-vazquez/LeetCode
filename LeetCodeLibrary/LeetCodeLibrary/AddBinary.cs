using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class AddBinary
    {
        public string AddTheBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();

            int carry = 0;

            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                if (i >= 0)
                {
                    carry += a[i--] - '0';
                }
                if ( j >= 0)
                {
                    carry += b[j--] - '0';
                }
                result.Insert(0, carry % 2);
                carry /= 2;

                Console.WriteLine($"i: {i}, j: {j}, carry: {carry}, result: {result}");
            }

            return result.ToString();
        }
    }
}
