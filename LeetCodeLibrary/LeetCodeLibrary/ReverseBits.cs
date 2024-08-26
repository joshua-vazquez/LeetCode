using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ReverseBits
    {
        public uint ReverseBitsMethod(uint n)
        {
            // Initialize the result to 0
            uint result = 0;

            // Loop through each bit position from 0 to 31
            for (int i = 0; i < 32; i++)
            {
                // Shift result to the left by 1 bit
                result <<= 1;

                // Add the least significant bit of n to result
                result |= (n & 1);

                // Shift n to the right by 1 bit
                n >>= 1;
            }

            // Return the reversed bits
            return result;
        }
    }
}
