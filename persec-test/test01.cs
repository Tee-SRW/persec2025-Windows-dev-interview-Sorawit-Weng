using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using System.Collections.Generic;


namespace persec_test
{
    public class test01
    {
        public bool checkBracket(string input)
        {
            Dictionary<char, char> match = new Dictionary<char, char>();
            match.Add('(', ')');
            match.Add('{', '}');
            match.Add('[', ']');

            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (match.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (match[top] != c)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;

        }

    }
}