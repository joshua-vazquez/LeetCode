using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> parenths = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    parenths.Push(c);
                }
                else
                {
                    if (parenths.Count == 0)
                    {
                        return false;
                    }

                    char top = parenths.Pop();
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return parenths.Count == 0;
        }
    }
}
