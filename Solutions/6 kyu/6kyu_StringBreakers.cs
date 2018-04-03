using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class Kata
{
  public static string StringBreakers(int n, string str)
  {
    return String.Join("\n", (from Match m in Regex.Matches(str.Replace(" ", ""), @"[a-zA-Z]{1,"+n+"}") select m.Value).ToArray()); 
  }
}
