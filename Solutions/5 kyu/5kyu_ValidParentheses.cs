using System;
using System.Linq;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        if (input == "" || input == String.Empty) return true;
        var arr = input.Where(x => x == 40 || x == 41).ToArray();
        return arr.First() != 40 || arr.Last() == 40 || arr.Count() % 2 != 0  ? false : true;
    }
}
