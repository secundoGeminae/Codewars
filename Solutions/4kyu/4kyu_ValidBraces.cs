using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

   public static bool validBraces(String braces)
        {       
            Stack<char> stack = new Stack<char>();
            foreach (var item in braces.ToCharArray())
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == '}' || item == ']')
                {
                    if (stack.Count==0 || stack.Peek() != GetComplementBracket(item))
                    {
                         return false;
                    }
                  stack.Pop();
                }
            }
            return stack.Count == 0;
        }

        private static char GetComplementBracket(char item)
        {
            switch (item)
            {
                case ')':
                    return '(';
                case '}':
                    return '{';
                case ']':
                    return '[';
                default:
                    return ' ';
            }
        }
}
